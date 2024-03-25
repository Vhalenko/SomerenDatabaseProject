using System.Data;
using SomerenModel;

namespace SomerenDAL
{
    public class RoomDao : BaseDao<Room>
    {
        internal protected override Room Convert(DataRow reader)
        {
            int roomNumber = (int)reader["room_number"];
            string building = (string)reader["building"];
            int floor = (int)reader["floor"];
            int bedsAmount = (int)reader["beds_amount"];
            string roomType = (string)reader["room_type"];

            return new Room(roomNumber, building, floor, bedsAmount, roomType);
        }

        private protected override string GetAllQuery()
        {
            return "SELECT room_number, building, floor, beds_amount, room_type FROM room";
        }
    }
}