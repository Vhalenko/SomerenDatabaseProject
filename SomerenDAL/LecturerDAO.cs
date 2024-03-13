using SomerenModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace SomerenDAL
{
    public class LecturerDAO : BaseDao
    {
        public List<Lecturer> GetAllLecturers()
        {
            OpenConnection();
            SqlCommand query = new("SELECT * FROM lecturer", dbConnection);
            SqlDataReader reader = query.ExecuteReader();
            List<Lecturer> lecturers = new();

            while (reader.Read())
            {
                lecturers.Add(ReadLecturers(reader));
            }

            CloseConnection();
            return lecturers;
        }

        private Lecturer ReadLecturers(SqlDataReader reader)
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
