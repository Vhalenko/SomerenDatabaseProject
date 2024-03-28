using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SomerenService
{
    public class DrinkService
    {
        private DrinkDao drinkDao;
        protected const int ObjectIdBeforeDb = 0;

        public DrinkService()
        {
            drinkDao = new();
        }

        /*Get Drinks*/

        public List<Drink> GetDrinks()
        {
            return drinkDao.GetAll();
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
            int id = ObjectIdBeforeDb;
            string name = list[0];
            decimal price = decimal.Parse(list[1]);
            int stock = int.Parse(list[2]);
            int vat = int.Parse(list[3]);

            Drink drink = new(id, name, price, stock, vat);

            drinkDao.AddItem(drink);
        }

        /*Delete Drinks*/

        public void DeleteDrink(Drink drink)
        {
            drinkDao.DeleteItem(drink);
        }

        /*Update Drinks*/

        private void FillDrinkToUpdate(List<string> list)
        {
            int id = int.Parse(list[0]);
            string name = list[1];
            decimal price = decimal.Parse(list[2]);
            int stock = int.Parse(list[3]);
            int vat = int.Parse(list[4]);

            Drink drink = new(id, name, price, stock, vat);

            drinkDao.UpdateItem(drink);
        }

        public void CheckForUpdates(string filledName, string filledPrice, string filledStock, string filledVat, Drink oldDrink)
        {
            string name = string.IsNullOrWhiteSpace(filledName) ? oldDrink.Name : filledName;
            string price = string.IsNullOrWhiteSpace(filledPrice) ? oldDrink.Price.ToString() : filledPrice;
            string stock = string.IsNullOrWhiteSpace(filledStock) ? oldDrink.Stock.ToString() : filledStock;
            string vat = string.IsNullOrWhiteSpace(filledVat) ? oldDrink.Vat.ToString() : filledVat;
            DrinkService drinkService = new();

            drinkService.FillDrinkToUpdate(new List<string> { null, name, price, stock, vat });
        }
    }
}