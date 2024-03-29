using SomerenDAL;
using SomerenModel;
using System.Collections.Generic;

namespace SomerenService
{
    public class LecturerService
    {
        private LecturerDao lecturerDao;

        public LecturerService()
        {
            lecturerDao = new();
        }

        public List<Lecturer> GetLecturers()
        {
            return lecturerDao.GetAll();
        }

        public List<Lecturer> ShowActivitySupervisors(Activity activity)
        {
            return lecturerDao.ActivityInSupervisors(activity);
        }

        public void AddLecturer(int lecturer_number, int activity_id)
        {
            lecturerDao.AddLecturer(lecturer_number, activity_id);
        }

        public void DeleteLecturer(Lecturer lecturer)
        {
            lecturerDao.DeleteLecturer(lecturer);
        }

        public void UpdateLecturer(int lecturer_number, int activity_id)
        {
            lecturerDao.UpdateLecturer(lecturer_number, activity_id);
        }
    }
}