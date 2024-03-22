using SomerenModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace SomerenDAL
{
    public class OrderDao : BaseDao<Order>
    {
        private protected override string GetAllQuery()
        {
            return "SELECT purchase.quantity, purchase.order_date, student.*, drink.* FROM purchase JOIN student ON purchase.student_number = student.student_number JOIN drink ON purchase.drink_id = drink.drink_id;";
        }

        private protected override Order Convert(DataRow reader)
        {
            int quantity = (int)reader["quantity"];
            DateTime orderDate = (DateTime)reader["order_date"];

            return new Order(ConvertStudent(reader), ConvertDrink(reader), quantity, orderDate);
        }

        private Student ConvertStudent(DataRow reader)
        {
            int studentNumber = (int)reader["student_number"];
            string firstName = (string)reader["first_name"];
            string lastName = (string)reader["last_name"];
            string className = (string)reader["class"];
            string telephoneNumber = (string)reader["telephone_number"];
            int roomNumber = (int)reader["room_number"];
            return new Student(studentNumber, firstName, lastName, className, telephoneNumber, roomNumber);
        }

        private Drink ConvertDrink(DataRow reader)
        {
            int drinkId = (int)reader["drink_id"];
            string drinkName = (string)reader["name"];
            decimal price = (decimal)reader["price"];
            int stock = (int)reader["stock"];
            int vat = (int)reader["vat"];

            return new Drink(drinkId, drinkName, price, stock, vat);
        }

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

        public List<Order> GetAllDrinksByPercentage(DateTime startQuarterDate, DateTime endQuarterDate, int percentageVat)
        {
            return ReadTables(ExecuteSelectQuery(QueryForVat(), GetSqlParameters(startQuarterDate, endQuarterDate, percentageVat)));
        }

        private string QueryForVat()
        {
            return "SELECT purchase.quantity, purchase.order_date, drink.*, student.*" +
                    " FROM purchase" +
                    " JOIN student ON purchase.student_number = student.student_number" +
                    " JOIN drink ON purchase.drink_id = drink.drink_id" +
                    " WHERE purchase.order_date BETWEEN @startdatequarter AND @enddatequarter" +
                    " AND drink.vat = @vat";
        }

        private SqlParameter[] GetSqlParameters(DateTime startQuarterDate, DateTime endQuarterDate, int percentageVat)
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

        private int ReadCountOfCustomers(DataTable dataTable)
        {
            int StudentCount = 0;

            foreach (DataRow dataReader in dataTable.Rows)
            {
                StudentCount = (int)dataReader["count"];
            }

            return StudentCount;
        }
    }
}
