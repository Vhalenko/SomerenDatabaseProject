using SomerenModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace SomerenDAL
{
    public class LecturerDao : BaseDao<Lecturer>
    {
        internal protected override Lecturer Convert(DataRow reader)
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

        public void AddLecturer(int lecturerNumber, int activityId)
        {
            string query = "INSERT activity_supervice (lecturer_number, activity_id) VALUES (@lecturer_number, @activity_id)";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@lecturer_number", SqlDbType.Int){Value = lecturerNumber},
                new SqlParameter("@activity_id", SqlDbType.Int){Value = activityId}
            };

            ExecuteEditQuery(query, parameters);
        }

        public void DeleteLecturer(Lecturer lecturer)
        {
            string query = "DELETE FROM activity_supervice WHERE lecturer_number = @lecturer_number";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new("@lecturer_number", SqlDbType.Int) { Value = lecturer.PersonNumber}
            };

            ExecuteEditQuery(query, parameters);
        }

        public void UpdateLecturer(int lecturerNumber, int activityId)
        {
            string query = "UPDATE activity_supervice SET activity_id = @activity_id WHERE lecturer_number = @lecturer_number";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new("@lecturer_number", SqlDbType.Int) { Value = lecturerNumber },
                new("@activity_id", SqlDbType.Int) { Value = activityId }
            };

            ExecuteEditQuery(query, parameters);
        }

        public List<Lecturer> ActivityInSupervisors(Activity activity)
        {
            try
            {
                string query = @"SELECT l.lecturer_number, l.first_name, l.last_name, l.age, l.telephone_number, l.room_number FROM lecturer l WHERE l.lecturer_number IN (SELECT asv.lecturer_number FROM activity_supervice asv WHERE asv.activity_id = @activity_id)";

                SqlParameter[] parameters = new SqlParameter[]
                {
            new SqlParameter("@activity_id", SqlDbType.Int) { Value = activity.Id }
                };

                DataTable table = ExecuteSelectQuery(query, parameters);
                return ReadTables(table);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while retrieving data from the database. Details: " + ex.Message);
            }
        }
    }
}