using SomerenDAL;
using SomerenModel;
using System.Collections.Generic;

namespace SomerenService
{
    public class LecturerService
    {
        private LecturerDAO lecturerDAO;

        public LecturerService()
        {
            lecturerDAO = new LecturerDAO();
        }

        public List<Lecturer> GetLecturers()
        {
            return lecturerDAO.GetAllLecturers();
        }
    }
}
