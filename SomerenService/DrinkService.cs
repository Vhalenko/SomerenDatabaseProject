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
            return drinkdb.GetAllDrinks();
        }
    }
}
