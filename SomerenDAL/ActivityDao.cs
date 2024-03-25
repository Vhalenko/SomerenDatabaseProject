using SomerenModel;
using System.Data;

namespace SomerenDAL
{
    public class ActivityDao : BaseDao<Activity>
    {
        internal override Activity Convert(DataRow reader)
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
    }
}