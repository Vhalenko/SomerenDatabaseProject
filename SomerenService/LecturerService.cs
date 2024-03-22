using SomerenDAL;
using SomerenModel;
using System.Collections.Generic;

namespace SomerenService
{
    public class LecturerService
    {
        private LecturerDao lecturerDAO;

        public LecturerService()
        {
            lecturerDAO = new();
        }

        public List<Lecturer> GetLecturers()
        {
            return lecturerDAO.GetAll();
        }
    }
}
