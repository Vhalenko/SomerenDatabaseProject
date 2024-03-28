using SomerenModel;
using System;
using System.Data;
using System.Data.SqlClient;

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

        /*Query*/

        private protected override string GetAllQuery()
        {
            return "SELECT lecturer_number, first_name, last_name, age, telephone_number, room_number FROM lecturer";
        }

        protected override string QueryToAddItem()
        {
            return "INSERT lecturer(lecturer_number, first_name, last_name, age, telephone_number, room_number) VALUES(@lecturer_number, @first_name, @last_name, @age, @telephone_number, @room_number)";
        }

        protected override string QueryToDeleteItem()
        {
            return "DELETE FROM lecturer WHERE lecturer_number = @lecturer_number";
        }

        protected override string QueryToUpdateItem()
        {
            return "UPDATE lecturer SET first_name = @first_name, last_name = @last_name, age = @age, telephone_number = @telephone_number, room_number = @room_number WHERE lecturer_number = @lecturer_number";
        }

        /*Parameters*/

        protected override SqlParameter[] GetParametersToAddItem(Lecturer lecturer)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new("@student_number", SqlDbType.Int) {Value = lecturer.PersonNumber},
                new("@first_name", SqlDbType.VarChar) {Value = lecturer.FirstName},
                new("@last_name", SqlDbType.VarChar) {Value = lecturer.LastName},
                new("@class", SqlDbType.Date) {Value = lecturer.Age},
                new("@telephone_number", SqlDbType.VarChar) {Value = lecturer.TelephoneNumber},
                new("@room_number", SqlDbType.Int) {Value = lecturer.RoomNumber}
            };

            return parameters;
        }

        protected override SqlParameter[] GetParametersToDeleteItem(Lecturer lecturer)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new("@lecturer_number", SqlDbType.Int) {Value = lecturer.PersonNumber}
            };

            return parameters;
        }

        protected override SqlParameter[] GetParametersToUpdateItem(Lecturer lecturer)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new("@first_name", SqlDbType.VarChar) {Value = lecturer.FirstName},
                new("@last_name", SqlDbType.VarChar) {Value = lecturer.LastName},
                new("@age", SqlDbType.Date) {Value = lecturer.Age},
                new("@telephone_number", SqlDbType.VarChar) {Value = lecturer.TelephoneNumber},
                new("@room_number", SqlDbType.Int) {Value = lecturer.RoomNumber}
            };

            return parameters;
        }
    }
}