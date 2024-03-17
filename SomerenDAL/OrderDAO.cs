using SomerenModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace SomerenDAL
{
    public class OrderDAO : BaseDao
    {
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
