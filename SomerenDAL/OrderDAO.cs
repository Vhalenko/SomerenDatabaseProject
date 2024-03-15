using SomerenModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace SomerenDAL
{
    public class OrderDAO : BaseDao
    {
        public List<Student> GetAllStudents()
        {
            OpenConnection();
            SqlCommand query = new("SELECT * FROM student", dbConnection);
            SqlDataReader reader = query.ExecuteReader();
            List<Student> students = new();

            while (reader.Read())
            {
                students.Add(ReadStudents(reader));
            }

            CloseConnection();
            return students;
        }

        private Student ReadStudents(SqlDataReader reader)
        {
            int studentNumber = (int)reader["student_number"];
            string firstName = (string)reader["first_name"];
            string lastName = (string)reader["last_name"];
            string className = (string)reader["class"];
            string telephoneNumber = (string)reader["telephone_number"];
            int roomNumber = (int)reader["room_number"];

            return new Student(studentNumber, firstName, lastName, className, telephoneNumber, roomNumber);
        }

        public List<Drink> GetAllDrinks()
        {
            string query = "SELECT * FROM drink";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Drink> ReadTables(DataTable dataTable)
        {
            List<Drink> drinks = new();

            foreach (DataRow dataReader in dataTable.Rows)
            {
                int id = (int)dataReader["drink_id"];
                string name = (string)dataReader["name"];
                decimal price = (decimal)dataReader["price"];
                string stock = (string)dataReader["stock"];
                int vat = (int)dataReader["vat"];

                Drink drink = new(id, name, price, stock, vat);
                drinks.Add(drink);
            }
            return drinks;
        }
    }
}
