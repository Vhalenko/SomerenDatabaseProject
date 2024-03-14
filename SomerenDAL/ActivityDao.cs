using System.Collections.Generic;
using System.Data.SqlClient;

namespace SomerenDAL
{
    public class ActivityDao : BaseDao
    {
        public List<SomerenModel.Activity> GetAllActivities()
        {
            OpenConnection();

            SqlCommand cmd = new SqlCommand("SELECT * FROM activity", dbConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            List<SomerenModel.Activity> activities = new List<SomerenModel.Activity>();

            while (reader.Read()) 
            {
                SomerenModel.Activity activity = ReadActivity(reader);
                activities.Add(activity);
            }
            reader.Close();
            CloseConnection();

            return activities;
        }

        private SomerenModel.Activity ReadActivity(SqlDataReader reader)
        {
            int id = (int)reader["activity_id"];
            string name = (string)reader["name"];
            string startDayTime = (string)reader["start_day_time"];
            string endDayTime = (string)reader["end_day_time"];
            
            return new SomerenModel.Activity(id, name, startDayTime, endDayTime);
        }
    }
}
