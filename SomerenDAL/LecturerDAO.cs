using SomerenModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace SomerenDAL
{
    public class LecturerDao : BaseDao<Lecturer>
    {
        private const string LecturersRoomType = "single room";
        private const string LecturersTable = "lecturer";
        private const string ActivityTable = "activity";
        private const string ActivitySuperviceTable = "activity_supervice";
        private const string LecturerNumberColumn = "lecturer_number";
        private const string ActivityIdColumn = "activity_id";
        private const int PeoplePerSingleRoom = 1;

        internal protected override Lecturer ConvertItem(DataRow reader)
        {
            int lecturerNumber = (int)reader["lecturer_number"];
            string firstName = (string)reader["first_name"];
            string lastName = (string)reader["last_name"];
            DateTime age = (DateTime)reader["age"];
            string telephoneNumber = (string)reader["telephone_number"];
            int roomNumber = (int)reader["room_number"];

            return new Lecturer(lecturerNumber, firstName, lastName, age, telephoneNumber, roomNumber);
        }

        private protected override string GetAllQuery()
        {
            return "SELECT lecturer_number, first_name, last_name, age, telephone_number, room_number FROM lecturer";
        }

        public void AddSupervisor(int lecturerNumber, int activityId)
        {
            string query = "INSERT INTO activity_supervice (lecturer_number, activity_id) VALUES (@lecturer_number, @activity_id)";
            AddSupervisorException(lecturerNumber, activityId);

            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter(LecturerNumberColumn, SqlDbType.Int) { Value = lecturerNumber },
            new SqlParameter(ActivityIdColumn, SqlDbType.Int) { Value = activityId }
            };

            ExecuteEditQuery(query, parameters);
        }

        private void AddSupervisorException(int lecturerNumber, int activityId)
        {
            if (!IdExists(activityId, ActivityTable, ActivityIdColumn))
            {
                throw new Exception("Invalid input");
            }
            if (!IdExists(lecturerNumber, LecturersTable, LecturerNumberColumn))
            {
                throw new Exception("Invalid input");
            }
            if (IdExists(lecturerNumber, ActivitySuperviceTable, LecturerNumberColumn))
            {
                throw new Exception("Lecturer is already a supervisor for this activity.");
            }
        }

        public void DeleteSupervisor(Lecturer lecturer)
        {
            string query = "DELETE FROM activity_supervice WHERE lecturer_number = @lecturer_number";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter(LecturerNumberColumn, SqlDbType.Int) { Value = lecturer.PersonNumber }
            };
            ExecuteEditQuery(query, parameters);
        }

        public List<Lecturer> ActivityInSupervisors(Activity activity, bool differentmethod)
        {
            string difference = differentmethod ? "IN" : "NOT IN";
            string query = $@"SELECT l.lecturer_number, l.first_name, l.last_name, l.age, l.telephone_number, l.room_number FROM lecturer l WHERE l.lecturer_number {difference} (SELECT asv.lecturer_number FROM activity_supervice asv WHERE asv.activity_id = @activity_id)";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter(ActivityIdColumn, SqlDbType.Int) { Value = activity.Id }
            };

            DataTable table = ExecuteSelectQuery(query, parameters);
            return ReadTables(table);
        }

        public void DeleteLecturer(Lecturer lecturer)
        {
            string query = "DELETE FROM lecturer WHERE lecturer_number = @lecturer_number";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new("@lecturer_number", SqlDbType.Int) {Value = lecturer.PersonNumber}
            };

            ExecuteEditQuery(query, parameters);
        }

        public void AddLecturer(Lecturer lecturer)
        {
            CheckLecturerValues(lecturer);

            string query = "INSERT lecturer(lecturer_number, first_name, last_name, age, telephone_number, room_number) VALUES (@lecturer_number, @first_name, @last_name, @age, @telephone_number, @room_number)";

            ExecuteEditQuery(query, LecturerParameters(lecturer));
        }

        private void CheckLecturerValues(Lecturer lecturer)
        {
            if (IdExists(lecturer.PersonNumber, "lecturer", "lecturer_number"))
            {
                throw new Exception("This id already exists!");
            }

            CheckRoom(lecturer);
        }

        private void CheckRoom(Lecturer lecturer)
        {
            if (!RoomExists(lecturer.RoomNumber))
            {
                throw new Exception("This room does not exist!");
            }
            else if (RoomType(lecturer.RoomNumber) != LecturersRoomType)
            {
                throw new Exception($"The room is not a {LecturersRoomType}!");
            }
            else if (PeopleInRoom(lecturer.RoomNumber, LecturersTable) == PeoplePerSingleRoom && lecturer.PersonNumber != PersonIdInRoom(lecturer.RoomNumber, lecturer.PersonNumber, LecturersTable, LecturerNumberColumn, LecturerNumberColumn))
            {
                throw new Exception($"The room {lecturer.RoomNumber} has to many people!");
            }
        }

        public void UpdateLecturer(Lecturer lecturer)
        {
            CheckRoom(lecturer);

            string query = "UPDATE lecturer SET first_name = @first_name, last_name = @last_name, age = @age, telephone_number = @telephone_number, room_number = @room_number WHERE lecturer_number = @lecturer_number";
            ExecuteEditQuery(query, LecturerParameters(lecturer));
        }

        private SqlParameter[] LecturerParameters(Lecturer lecturer)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new("@lecturer_number", SqlDbType.Int) {Value = lecturer.PersonNumber},
                new("@first_name", SqlDbType.VarChar) {Value = lecturer.FirstName},
                new("@last_name", SqlDbType.VarChar) {Value = lecturer.LastName},
                new("@age", SqlDbType.Date) {Value = lecturer.Age},
                new("@telephone_number", SqlDbType.VarChar) {Value = lecturer.TelephoneNumber},
                new("@room_number", SqlDbType.Int) {Value = lecturer.RoomNumber}
            };

            return parameters;
        }
    }
}