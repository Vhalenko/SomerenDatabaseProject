﻿using SomerenModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace SomerenDAL
{
    public class OrderDao : BaseDao<Order>
    {
        /*Convert*/

        internal protected override Order ConvertItem(DataRow reader)
        {
            StudentDao studentDao = new();
            DrinkDao drinkDao = new();

            int id = (int)reader["purchase_id"];
            int quantity = (int)reader["quantity"];
            DateTime orderDate = (DateTime)reader["order_date"];

            return new Order(id, studentDao.ConvertItem(reader), drinkDao.ConvertItem(reader), quantity, orderDate);
        }

        private int ReadCountOfCustomers(DataTable dataTable)
        {
            int StudentCount = 0;

            foreach (DataRow dataReader in dataTable.Rows)
            {
                StudentCount = (int)dataReader["count"];
            }

            return StudentCount;
        }

        /*Query*/

        private protected override string GetAllQuery()
        {
            return "SELECT purchase.purchase_id, purchase.quantity, purchase.order_date, student.*, drink.* FROM purchase JOIN student ON purchase.student_number = student.student_number JOIN drink ON purchase.drink_id = drink.drink_id;";
        }

        private string QueryForVat()
        {
            return "SELECT purchase.purchase_id, purchase.quantity, purchase.order_date, drink.*, student.*" +
                    " FROM purchase" +
                    " JOIN student ON purchase.student_number = student.student_number" +
                    " JOIN drink ON purchase.drink_id = drink.drink_id" +
                    " WHERE purchase.order_date BETWEEN @startdatequarter AND @enddatequarter" +
                    " AND drink.vat = @vat";
        }

        /*CRUD*/

        public void CreateOrder(Student student, Drink drink, int quantity, DateTime dateOfOrder)
        {
            AddOrder(student, drink, quantity, dateOfOrder);
            ChangeStock(drink, quantity);
        }

        public void AddOrder(Student student, Drink drink, int quantity, DateTime dateOfOrder)
        {
            string query = "INSERT INTO purchase (student_number, drink_id, quantity, order_date) VALUES (@studentNumber, @drinkId, @quantity, @orderDate)";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new("@studentNumber", SqlDbType.Int) {Value = student.PersonNumber},
                new("@drinkId", SqlDbType.Int) {Value = drink.Id},
                new("@quantity", SqlDbType.Int) {Value = quantity},
                new("@orderDate", SqlDbType.Date) {Value = dateOfOrder}
            };

            ExecuteEditQuery(query, parameters);
        }

        private void ChangeStock(Drink drink, int quantity)
        {

            string query = "UPDATE drink SET stock = stock - @quantity WHERE drink_id = @drinkId";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new("@quantity", SqlDbType.Int) {Value = quantity},
                new("@drinkId", SqlDbType.Int) {Value = drink.Id}
            };

            ExecuteEditQuery(query, parameters);
        }

        /*Get from database*/

        public List<Order> GetAllDrinksByPercentage(DateTime startQuarterDate, DateTime endQuarterDate, int percentageVat)
        {
            return ReadTables(ExecuteSelectQuery(QueryForVat(), GetBySqlParameters(startQuarterDate, endQuarterDate, percentageVat)));
        }

        private SqlParameter[] GetBySqlParameters(DateTime startQuarterDate, DateTime endQuarterDate, int percentageVat)
        {
            SqlParameter[] SqlParameters = new SqlParameter[]
            {
                new("@startDateQuarter", SqlDbType.Date) {Value = startQuarterDate},
                new("@endDateQuarter", SqlDbType.Date) {Value = endQuarterDate},
                new("@vat", SqlDbType.Int) {Value = percentageVat}
            };

            return SqlParameters;
        }

        public int CountAmountOfClients(DateTime startDate, DateTime endDate)
        {
            string query = "SELECT COUNT(DISTINCT student_number) AS [count] FROM purchase WHERE order_date BETWEEN @startDate AND @endDate";

            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new ("@startDate", SqlDbType.Date) {Value = startDate},
                new ("@endDate", SqlDbType.Date) {Value = endDate}
            };

            return ReadCountOfCustomers(ExecuteSelectQuery(query, sqlParameters));
        }
    }
}