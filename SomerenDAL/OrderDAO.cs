using SomerenModel;
using System;
using System.Data;
using System.Data.SqlClient;

namespace SomerenDAL
{
    public class OrderDAO : BaseDao<Order>
    {
        public OrderDAO() : base()
        {
            query = "SELECT purchase.quantity, purchase.order_date, student.*, drink.* FROM purchase JOIN student ON purchase.student_number = student.student_number JOIN drink ON purchase.drink_id = drink.drink_id;";
        }

        private protected override Order WriteItem(DataRow reader)
        {
            int quantity = (int)reader["quantity"];
            DateTime orderDate = (DateTime)reader["order_date"];

            int studentNumber = (int)reader["student_number"];
            string firstName = (string)reader["first_name"];
            string lastName = (string)reader["last_name"];
            string className = (string)reader["class"];
            string telephoneNumber = (string)reader["telephone_number"];
            int roomNumber = (int)reader["room_number"];
            Student student = new(studentNumber, firstName, lastName, className, telephoneNumber, roomNumber);

            int drinkId = (int)reader["drink_id"];
            string drinkName = (string)reader["name"];
            decimal price = (decimal)reader["price"];
            int stock = (int)reader["stock"];
            int vat = (int)reader["vat"];

            Drink drink = new(drinkId, drinkName, price, stock, vat);

            return new Order(student, drink, quantity, orderDate);
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
                new SqlParameter("@studentNumber", SqlDbType.Int) {Value = student.PersonNumber},
                new SqlParameter("@drinkId", SqlDbType.Int) {Value = drink.Id},
                new SqlParameter("@quantity", SqlDbType.Int) {Value = quantity},
                new SqlParameter("@orderDate", SqlDbType.Date) {Value = dateOfOrder}
            };

            ExecuteEditQuery(query, parameters);
        }

        private void ChangeStock(Drink drink, int quantity)
        {

            string query = "UPDATE drink SET stock = stock - @quantity WHERE drink_id = @drinkId";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@quantity", SqlDbType.Int) {Value = quantity},
                new SqlParameter("@drinkId", SqlDbType.Int) {Value = drink.Id}
            };

            ExecuteEditQuery(query, parameters);
        }
    }
}
