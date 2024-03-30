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

        public List<Lecturer> ShowActivitySupervisors(Activity activity, bool difference)
        {
            return lecturerDao.ActivityInSupervisors(activity, difference);
        }

        public void AddSupervisor(int lecturer_number, int activity_id)
        {
            lecturerDao.AddSupervisor(lecturer_number, activity_id);
        }

        public void DeleteSupervisor(Lecturer lecturer)
        {
            lecturerDao.DeleteSupervisor(lecturer);
        }

        public void UpdateSupervisor(int lecturer_number, int activity_id)
        {
            lecturerDao.UpdateSupervisor(lecturer_number, activity_id);
        }

        public void DeleteLecturer(Lecturer lecturer)
        {
            lecturerDao.DeleteLecturer(lecturer);
        }

        public void AddLecturer(Lecturer lecturer)
        {
            lecturerDao.AddLecturer(lecturer);
        }

        public void UpdateLecturer(Lecturer lecturer)
        {
            lecturerDao.UpdateLecturer(lecturer);
        }
    }
}