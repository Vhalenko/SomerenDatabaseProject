using SomerenDAL;
using SomerenModel;
using System.Collections.Generic;

namespace SomerenService
{
    public class StudentService
    {
        private StudentDao studentDAO;

        public StudentService()
        {
            studentDAO = new StudentDao();
        }

        public List<Student> GetStudents()
        {
            return studentDAO.GetAllStudents();
        }
    }
}