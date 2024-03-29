using System;
using System.Data;
using System.Data.SqlClient;
using SomerenModel;

namespace SomerenDAL
{
    public class StudentDao : BaseDao<Student>
    {
        internal protected override Student ConvertItem(DataRow reader)
        {
            int studentNumber = (int)reader["student_number"];
            string firstName = (string)reader["first_name"];
            string lastName = (string)reader["last_name"];
            string className = (string)reader["class"];
            string telephoneNumber = (string)reader["telephone_number"];
            int roomNumber = (int)reader["room_number"];

            return new Student(studentNumber, firstName, lastName, className, telephoneNumber, roomNumber);
        }

        private protected override string GetAllQuery()
        {
            return "SELECT student_number, first_name, last_name, class, telephone_number, room_number FROM student";
        }

        public void DeleteStudent(Student student)
        {
            string query = "DELETE FROM student WHERE student_number = @student_number";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new("@student_number", SqlDbType.Int) {Value = student.PersonNumber}
            };

            ExecuteEditQuery(query, parameters);
        }

        public void AddStudent(Student student)
        {
            CheckStudentValues(student);

            string query = "INSERT student(student_number, first_name, last_name, class, telephone_number, room_number) VALUES (@student_number, @first_name, @last_name, @class, @telephone_number, @room_number)";

            ExecuteEditQuery(query, StudentParameters(student));
        }

        private void CheckStudentValues(Student student)
        {
            if (IdExists(student.PersonNumber, "student", "student_number"))
            {
                throw new Exception("This id already exists!");
            }
            
            CheckExistanceOfRoom(student.RoomNumber);
        }

        private void CheckExistanceOfRoom(int roomNumber)
        {
            if (!RoomExists(roomNumber))
            {
                throw new Exception("This room does not exist!");
            }
        }

        public void UpdateStudent(Student student)
        {
            CheckExistanceOfRoom(student.RoomNumber);

            string query = "UPDATE student SET first_name = @first_name, last_name = @last_name, class = @class, telephone_number = @telephone_number, room_number = @room_number WHERE student_number = @student_number";
            ExecuteEditQuery(query, StudentParameters(student));
        }

        private SqlParameter[] StudentParameters(Student student)
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
    }
}