using SomerenModel;
using System.Data;

namespace SomerenDAL
{
    public class DrinkDao : BaseDao<Drink>
    {
        public DrinkDao() : base()
        {
            query = "SELECT * FROM drink";
        }

        private protected override Drink WriteItem(DataRow reader)
        {
            int id = (int)reader["drink_id"];
            string name = (string)reader["name"];
            decimal price = (decimal)reader["price"];
            int stock = (int)reader["stock"];
            int vat = (int)reader["vat"];

            return new Drink(id, name, price, stock, vat);
        }
    }
}
