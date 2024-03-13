using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenModel;

namespace SomerenDAL
{
    public class RoomDao : BaseDao
    {
        public List<Room> GetAllRooms()
        {
            string query = "SELECT * FROM room";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<Room> ReadTables(DataTable dataTable)
        {
            List<Room> rooms = new List<Room>();

            foreach (DataRow dataReader in dataTable.Rows)
            {
                int roomNumber = (int)dataReader["room_number"];
                string building = (string)dataReader["building"];
                int floor = (int)dataReader["floor"];
                int bedsAmount = (int)dataReader["beds_amount"];
                string roomType = (string)dataReader["room_type"];

                Room room = new(roomNumber, building, floor, bedsAmount, roomType);
                rooms.Add(room);
            }
            return rooms;
        }
    }
}
