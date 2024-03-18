using SomerenModel;
using System.Data;

namespace SomerenDAL
{
    public class ActivityDao : BaseDao<Activity>
    {
        public ActivityDao() : base()
        {
            query = "SELECT * FROM activity";
        }

        private protected override Activity WriteItem(DataRow reader)
        {
            int id = (int)reader["activity_id"];
            string name = (string)reader["name"];
            string startDayTime = (string)reader["start_day_time"];
            string endDayTime = (string)reader["end_day_time"];

            return new Activity(id, name, startDayTime, endDayTime);
        }
    }
}
