using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SomerenService
{
    public class DrinkService
    {
        private DrinkDao drinkdb;

        public DrinkService()
        {
            drinkdb = new();
        }

        /*Get Drinks*/

        public List<Drink> GetDrinks()
        {
            return drinkdb.GetAll();
        }

        /*Add Drinks*/

        public void AddDrink(List<string> list)
        {
            if (list.Any(x => x == ""))
            {
                throw new Exception("Enter all values!");
            }
            else
            {
                FillDrinkToAdd(list);
            }
        }

        private void FillDrinkToAdd(List<string> list)
        {
            int id = int.Parse(list[0]);
            string name = list[1];
            decimal price = decimal.Parse(list[2]);
            int stock = int.Parse(list[3]);
            int vat = int.Parse(list[4]);

            Drink drink = new(id, name, price, stock, vat);

            drinkdb.AddDrink(drink);
        }

        /*Remove Drinks*/

        public void DeleteDrink(Drink drink)
        {
            drinkdb.DeleteDrink(drink);
        }

        /*Update Drinks*/

        public void UpdateDrink(List<string> list)
        {
            FillDrinkToUpdate(list);
        }

        private void FillDrinkToUpdate(List<string> list)
        {
            int id = int.Parse(list[0]);
            string name = list[1];
            decimal price = decimal.Parse(list[2]);
            int stock = int.Parse(list[3]);
            int vat = int.Parse(list[4]);

            Drink drink = new(id, name, price, stock, vat);

            drinkdb.UpdateDrink(drink);
        }
    }
}
