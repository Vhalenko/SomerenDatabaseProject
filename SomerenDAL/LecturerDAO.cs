using SomerenModel;
using System;
using System.Data;

namespace SomerenDAL
{
    public class LecturerDAO : BaseDao<Lecturer>
    {
        public LecturerDAO() : base()
        {
            query = "SELECT * FROM lecturer";
        }

        private protected override Lecturer WriteItem(DataRow reader)
        {
            int lecturerNumber = (int)reader["lecturer_number"];
            string firstName = (string)reader["first_name"];
            string lastName = (string)reader["last_name"];
            DateTime age = (DateTime)reader["age"];
            string telephoneNumber = (string)reader["telephone_number"];
            int roomNumber = (int)reader["room_number"];

            return new Lecturer(lecturerNumber, firstName, lastName, age, telephoneNumber, roomNumber);
        }
    }
}
