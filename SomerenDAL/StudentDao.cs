using System.Data;
using System.Data.SqlClient;
using SomerenModel;

namespace SomerenDAL
{
    public class StudentDao : BaseDao<Student>
    {
        internal protected override Student Convert(DataRow reader)
        {
            int studentNumber = (int)reader["student_number"];
            string firstName = (string)reader["first_name"];
            string lastName = (string)reader["last_name"];
            string className = (string)reader["class"];
            string telephoneNumber = (string)reader["telephone_number"];
            int roomNumber = (int)reader["room_number"];

            return new Student(studentNumber, firstName, lastName, className, telephoneNumber, roomNumber);
        }

        /*Query*/

        private protected override string GetAllQuery()
        {
            return "SELECT student_number, first_name, last_name, class, telephone_number, room_number FROM student";
        }
        protected override string QueryToAddItem()
        {
            return "INSERT student(student_number, first_name, last_name, class, telephone_number, room_number) VALUES(@student_number, @first_name, @last_name, @class, @telephone_number, @room_number)";
        }

        protected override string QueryToDeleteItem()
        {
            return "DELETE FROM student WHERE student_number = @student_number";
        }

        protected override string QueryToUpdateItem()
        {
            return "UPDATE student SET first_name = @first_name, last_name = @last_name, class = @class, telephone_number = @telephone_number, room_number = @room_number WHERE student_number = @student_number";
        }

        /*Parameters*/

        protected override SqlParameter[] GetParametersToAddItem(Student student)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new("@student_number", SqlDbType.Int) {Value = student.PersonNumber},
                new("@first_name", SqlDbType.VarChar) {Value = student.FirstName},
                new("@last_name", SqlDbType.VarChar) {Value = student.LastName},
                new("@class", SqlDbType.VarChar) {Value = student.ClassName},
                new("@telephone_number", SqlDbType.VarChar) {Value = student.TelephoneNumber},
                new("@room_number", SqlDbType.Int) {Value = student.RoomNumber}
            };

            return parameters;
        }

        protected override SqlParameter[] GetParametersToDeleteItem(Student student)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new("@student_number", SqlDbType.Int) {Value = student.PersonNumber}
            };

            return parameters;
        }

        protected override SqlParameter[] GetParametersToUpdateItem(Student student)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new("@first_name", SqlDbType.VarChar) {Value = student.FirstName},
                new("@last_name", SqlDbType.VarChar) {Value = student.LastName},
                new("@class", SqlDbType.VarChar) {Value = student.ClassName},
                new("@telephone_number", SqlDbType.VarChar) {Value = student.TelephoneNumber},
                new("@room_number", SqlDbType.Int) {Value = student.RoomNumber}
            };

            return parameters;
        }
    }
}