using SomerenDAL;
using SomerenModel;
using System.Collections.Generic;

namespace SomerenService
{
    public class StudentService
    {
        private StudentDao studentDao;

        public StudentService()
        {
            studentDao = new StudentDao();
        }

        public List<Student> GetStudents()
        {
            return studentDao.GetAll();
        }

        public void DeleteStudent(Student student)
        {
            studentDao.DeleteStudent(student);
        }

        public void AddStudent(Student student)
        {
            studentDao.AddStudent(student);
        }

        public void UpdateStudent(Student student)
        {
            studentDao.UpdateStudent(student);
        }

        public void AddParticipant(Student student, Activity activity)
        {
            studentDao.AddParticipant(student, activity);
        }

        public void DeleteParticipant(Student student)
        {
            studentDao.DeleteParticipant(student);
        }

        public List<Student> ShowActivityParticipants(Activity activity, bool difference)
        {
            return studentDao.ActivityInParticipants(activity, difference);
        }
    }
}