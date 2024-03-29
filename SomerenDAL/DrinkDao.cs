using SomerenModel;
using System.Data;
using System.Data.SqlClient;

namespace SomerenDAL
{
    public class DrinkDao : BaseDao<Drink>
    {
        internal protected override Drink ConvertItem(DataRow reader)
        {
            int id = (int)reader["drink_id"];
            string name = (string)reader["name"];
            decimal price = (decimal)reader["price"];
            int stock = (int)reader["stock"];
            int vat = (int)reader["vat"];

            return new Drink(id, name, price, stock, vat);
        }

        private protected override string GetAllQuery()
        {
            return "SELECT drink_id, name, price, stock, vat FROM drink";
        }

        /*CRUD*/

        public void AddDrink(Drink drink)
        {
            string query = "INSERT drink(name, price, stock, vat) VALUES (@name, @price, @stock, @vat)";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new("@name", SqlDbType.VarChar) {Value = drink.Name},
                new("@price", SqlDbType.Decimal) {Value = drink.Price},
                new("@stock", SqlDbType.Int) {Value = drink.Stock},
                new("@vat", SqlDbType.Int) {Value = drink.Vat}
            };

            ExecuteEditQuery(query, parameters);
        }

        public void DeleteDrink(Drink drink)
        {
            string query = "DELETE FROM drink WHERE drink_id = @id";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new("@id", SqlDbType.Int) {Value = drink.Id}
            };

            ExecuteEditQuery(query, parameters);
        }

        public void UpdateDrink(Drink drink)
        {
            string query = "UPDATE drink SET name = @name, price = @price, stock = @stock, vat = @vat WHERE drink_id = @id";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new("@id", SqlDbType.Int) {Value = drink.Id},
                new("@name", SqlDbType.VarChar) {Value = drink.Name},
                new("@price", SqlDbType.Decimal) {Value = drink.Price},
                new("@stock", SqlDbType.Int) {Value = drink.Stock},
                new("@vat", SqlDbType.Int) {Value = drink.Vat}
            };

            ExecuteEditQuery(query, parameters);
        }
    }
}