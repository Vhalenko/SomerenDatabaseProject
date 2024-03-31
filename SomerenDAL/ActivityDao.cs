using SomerenModel;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace SomerenDAL
{
    public class ActivityDao : BaseDao<Activity>
    {
        internal protected override Activity ConvertItem(DataRow reader)
        {
            int id = (int)reader["activity_id"];
            string name = (string)reader["name"];
            string startDayTime = (string)reader["start_day_time"];
            string endDayTime = (string)reader["end_day_time"];

            return new Activity(id, name, startDayTime, endDayTime);
        }

        private protected override string GetAllQuery()
        {
            return "SELECT activity_id, name, start_day_time, end_day_time FROM activity";
        }

        public List<Activity> GetActivitiesForParticipant(Student student)
        {
            List<Activity> activities = new List<Activity>();
            string query = "SELECT A.* FROM activity A JOIN activity_participate AP ON A.activity_id = AP.activity_id JOIN student S ON S.student_number = AP.student_number WHERE S.student_number = @student_number;";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@student_number", SqlDbType.Int) {Value = student.PersonNumber}
            };

            DataTable dataTable = ExecuteSelectQuery(query, parameters);
            return ReadTables(dataTable);
        }
    }
}