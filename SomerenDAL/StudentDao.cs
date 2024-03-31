using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using SomerenModel;

namespace SomerenDAL
{
    public class StudentDao : BaseDao<Student>
    {
        private const string StudentsRoomType = "dormitory";
        private const string StudentsTable = "student";
        private const string StudentNumberColumn = "student_number";
        private const int PeoplePerDormitory = 8;
        private const string ActivityIdColumn = "activity_id";

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
            
            CheckRoom(student);
        }

        private void CheckRoom(Student student)
        {
            if (!RoomExists(student.RoomNumber))
            {
                throw new Exception("This room does not exist!");
            }
            else if (RoomType(student.RoomNumber) != StudentsRoomType)
            {
                throw new Exception($"The room is not a {StudentsRoomType}!");
            }
            else if (PeopleInRoom(student.RoomNumber, StudentsTable) == PeoplePerDormitory && student.PersonNumber != PersonIdInRoom(student.RoomNumber, student.PersonNumber, StudentsTable, StudentNumberColumn, StudentNumberColumn))
            {
                throw new Exception($"The room {student.RoomNumber} has to many people!");
            }
        }

        public void UpdateStudent(Student student)
        {
            CheckRoom(student);

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

        public void AddParticipant(Student student, Activity activity)
        {
            string query = "INSERT activity_participate(student_number, activity_id) VALUES(@student_number, @activity_id)";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new("@student_number", SqlDbType.Int) {Value = student.PersonNumber},
                new("@activity_id", SqlDbType.Int) {Value = activity.Id}
            };

            ExecuteEditQuery(query, parameters);
        }

        public void DeleteParticipant(Student student, Activity activity)
        {
            string query = "DELETE FROM activity_participate WHERE student_number = @student_number AND activity_id = @activity_id";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new("@student_number", SqlDbType.Int) {Value = student.PersonNumber},
                new("@activity_id", SqlDbType.Int) {Value = activity.Id},

            };

            ExecuteEditQuery(query, parameters);
        }

        public List<Student> ActivityInParticipants(Activity activity, bool differentmethod)
        {
            string difference = differentmethod ? "IN" : "NOT IN";
            string query = $@"SELECT s.student_number, s.first_name, s.last_name, s.class, s.telephone_number, s.room_number FROM student s WHERE s.student_number {difference} (SELECT asv.student_number FROM activity_participate asv WHERE asv.activity_id = @activity_id)";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter(ActivityIdColumn, SqlDbType.Int) { Value = activity.Id }
            };

            DataTable table = ExecuteSelectQuery(query, parameters);
            return ReadTables(table);
        }
    }
}