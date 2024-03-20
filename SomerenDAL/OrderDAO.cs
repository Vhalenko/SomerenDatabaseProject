using SomerenModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace SomerenDAL
{
    public class OrderDAO : BaseDao<Order>
    {
        private protected override Order Convert(DataRow reader)
        {
            int quantity = (int)reader["quantity"];
            DateTime orderDate = (DateTime)reader["order_date"];

            return new Order(ConvertStudent(reader), ConvertDrink(reader), quantity, orderDate);
        }

        private protected override string GetAllQuery()
        {
            return "SELECT purchase.quantity, purchase.order_date, student.*, drink.* FROM purchase JOIN student ON purchase.student_number = student.student_number JOIN drink ON purchase.drink_id = drink.drink_id;";
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
        public List<Order> Drinks9Percent(DateTime startQuarterDate, DateTime endQuarterDate)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(GetSQLCommand(startQuarterDate, endQuarterDate, 9));
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            List<Order> orders = new List<Order>();
            foreach (DataRow row in dataTable.Rows)
            {
                Order order = Convert(row);
                orders.Add(order);
            }

            return orders;
        }

        public List<Order> Drinks21Percent(DateTime startQuarterDate, DateTime endQuarterDate)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(GetSQLCommand(startQuarterDate, endQuarterDate, 21));

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            List<Order> orders = new List<Order>();

            foreach (DataRow row in dataTable.Rows)
            {
                Order order = Convert(row);
                orders.Add(order);
            }

            return orders;
        }

        public SqlCommand GetSQLCommand(DateTime startQuarterDate, DateTime endQuarterDate, int percentageVAT)
        {
            string query = @"SELECT p.drink_id, d.name AS drink_name, p.quantity, p.order_date 
             FROM purchase p 
             JOIN drink d ON p.drink_id = d.drink_id 
             WHERE p.order_date BETWEEN @startdatequarter AND @enddatequarter
             AND d.vat = @vat";

            SqlCommand cmd = new SqlCommand(query, dbConnection);
            cmd.Parameters.AddWithValue("@startdatequarter", startQuarterDate.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@enddatequarter", endQuarterDate.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@vat", percentageVAT);

            return cmd;
        }
    }
}
