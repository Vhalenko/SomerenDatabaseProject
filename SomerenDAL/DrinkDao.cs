using SomerenModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenDAL
{
    public class DrinkDao : BaseDao
    {
        public List<Drink> GetAllDrinks()
        {
            string query = "SELECT * FROM drink";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<Drink> ReadTables(DataTable dataTable)
        {
            List<Drink> drinks = new List<Drink>();

            foreach (DataRow dataReader in dataTable.Rows)
            {
                int id = (int)dataReader["drink_id"];
                string name = (string)dataReader["name"];
                decimal price = (decimal)dataReader["price"];
                string stock = (string)dataReader["stock"];
                int vat = (int)dataReader["vat"];

                Drink drink = new(id, name, price, stock, vat);
                drinks.Add(drink);
            }
            return drinks;
        }
    }
}
