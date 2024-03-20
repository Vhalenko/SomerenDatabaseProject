using System.Data;
using System.Data.SqlClient;
using SomerenModel;

namespace SomerenDAL
{
    public class StudentDao : BaseDao<Student>
    {
        public StudentDao() : base() 
        {
            query = "SELECT student_number, first_name, last_name, class, telephone_number, room_number FROM student";
        }

        private protected override Student WriteItem(DataRow reader)
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