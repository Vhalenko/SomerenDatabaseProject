using SomerenModel;
using System.Data;

namespace SomerenDAL
{
    public class ActivityDao : BaseDao<Activity>
    {
        internal protected override Activity Convert(DataRow reader)
        {
            int id = (int)reader["activity_id"];
            string name = (string)reader["name"];
            string startDayTime = (string)reader["start_day_time"];
            string endDayTime = (string)reader["end_day_time"];

            return new Activity(id, name, startDayTime, endDayTime);
        }

        protected override string QueryToAddItem()
        {
            return "INSERT activity(activity_id, name, start_day-time, end_day_time) VALUES (@activity_id, @name, @start_day-time, @end_day_time)";
        }

        private protected override string GetAllQuery()
        {
            return "SELECT activity_id, name, start_day-time, end_day_time FROM activity";
        }

        protected override string QueryToDeleteItem()
        {
            return "DELETE * FROM activity WHERE activity_id = @id";
        }
    }
}