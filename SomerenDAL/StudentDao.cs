using System.Collections.Generic;
using System.Data.SqlClient;
using SomerenModel;

namespace SomerenDAL
{
    public class StudentDao : BaseDao
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
    }
}