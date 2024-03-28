using SomerenModel;
using System.Data;
using System.Data.SqlClient;

namespace SomerenDAL
{
    public class DrinkDao : BaseDao<Drink>
    {
        internal protected override Drink Convert(DataRow reader)
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
        protected override string QueryToAddItem()
        {
            return "INSERT drink(drink_id, name, price, stock, vat) VALUES(@drink_id, @name, @price, @stock, @vat)";
        }

        protected override string QueryToDeleteItem()
        {
            return "DELETE FROM drink WHERE drinl_id = @drink_id";
        }

        protected override string QueryToUpdateItem()
        {
            return "UPDATE drink SET name = @name, price = @price, stock = @stock, vat = @vat WHERE drink_id = @drink_id";
        }

        /*CRUD*/

        protected override SqlParameter[] GetParametersToAddItem(Drink drink)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new("@name", SqlDbType.VarChar) {Value = drink.Name},
                new("@price", SqlDbType.Decimal) {Value = drink.Price},
                new("@stock", SqlDbType.Int) {Value = drink.Stock},
                new("@vat", SqlDbType.Int) {Value = drink.Vat}
            };

            return parameters;
        }

        protected override SqlParameter[] GetParametersToDeleteItem(Drink drink)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new("@drink_id", SqlDbType.Int) {Value = drink.Id}
            };

            return parameters;
        }

        protected override SqlParameter[] GetParametersToUpdateItem(Drink drink)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new("@name", SqlDbType.VarChar) {Value = drink.Name},
                new("@price", SqlDbType.Decimal) {Value = drink.Price},
                new("@stock", SqlDbType.Int) {Value = drink.Stock},
                new("@vat", SqlDbType.Int) {Value = drink.Vat}
            };

            return parameters;
        }
    }
}