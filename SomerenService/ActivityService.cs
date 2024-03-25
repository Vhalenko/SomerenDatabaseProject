using SomerenDAL;
using SomerenModel;
using System.Collections.Generic;

namespace SomerenService
{
    public class ActivityService
    {
        private ActivityDao activityDao;

        public ActivityService()
        {
            activityDao = new();
        }

        public List<Activity> GetActivities()
        {
            return activityDao.GetAll();
        }
    }
}