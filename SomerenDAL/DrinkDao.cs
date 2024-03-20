using SomerenModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Xml.Linq;

namespace SomerenDAL
{
    public class DrinkDao : BaseDao<Drink>
    {
        public DrinkDao() : base()
        {
            query = "SELECT drink_id, name, price, stock, vat FROM drink";
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

        public void AddDrink(int id, string name, decimal price, int stock, int vat)
        {
            string query = "INSERT drink(drink_id, name, price, stock, vat) VALUES (@drink_id, @name, @price, @stock, @vat)";
            
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@drink_id", SqlDbType.Int) {Value = id},
                new SqlParameter("@name", SqlDbType.VarChar) {Value = name},
                new SqlParameter("@price", SqlDbType.Decimal) {Value = price},
                new SqlParameter("@stock", SqlDbType.Int) {Value = stock},
                new SqlParameter("@vat", SqlDbType.Int) {Value = vat}
            };

            ExecuteEditQuery(query, parameters);
        }
        public void DeleteDrink(int id)
        {
            string query = "DELETE FROM drink WHERE drink_id = @id";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@id", SqlDbType.Int) {Value = id}
            };

            ExecuteEditQuery(query, parameters);
        }
    }
}
