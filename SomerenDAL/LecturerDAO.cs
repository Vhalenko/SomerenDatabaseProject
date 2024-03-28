using SomerenModel;
using System;
using System.Data;

namespace SomerenDAL
{
    public class LecturerDao : BaseDao<Lecturer> 
    {
        internal protected override Lecturer Convert(DataRow reader)
        {
            int lecturerNumber = (int)reader["lecturer_number"];
            string firstName = (string)reader["first_name"];
            string lastName = (string)reader["last_name"];
            DateTime age = (DateTime)reader["age"];
            string telephoneNumber = (string)reader["telephone_number"];
            int roomNumber = (int)reader["room_number"];

            return new Lecturer(lecturerNumber, firstName, lastName, age, telephoneNumber, roomNumber);
        }

        private protected override string GetAllQuery()
        {
            return "SELECT lecturer_number, first_name, last_name, age, telephone_number, room_number FROM lecturer";
        }
    }
}