using SomerenDAL;
using SomerenModel;
using System.Collections.Generic;

namespace SomerenService
{
    public class StudentService : BaseService<Student>
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
            studentDao.DeleteItem(student);
        }

        public void AddStudent(Student student)
        {
            studentDao.AddItem(student);
        }

        public void UpdateStudent(Student newStudent, Student student)
        {
            studentDao.UpdateItem(CheckForUpdates(newStudent, student));
        }
    }
}