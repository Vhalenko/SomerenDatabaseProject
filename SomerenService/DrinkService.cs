using SomerenDAL;
using SomerenModel;
using System.Collections.Generic;

namespace SomerenService
{
    public class DrinkService
    {
        private DrinkDao drinkdb;

        public DrinkService()
        {
            drinkdb = new();
        }

        public List<Drink> GetDrinks()
        {
            return drinkdb.GetAll();
        }
        public void AddDrink(int id, string name, decimal price, int stock, int vat)
        {
            drinkdb.AddDrink(id, name, price, stock, vat);
        }
        public void RemoveDrink(int id)
        {
            drinkdb.DeleteDrink(id);
        }
        public void UpdateDrink(int id, string name, decimal price, int stock, int vat)
        {
            drinkdb.UpdateDrink(id, name, price, stock, vat);
        }
    }
}
