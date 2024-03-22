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

        public void AddDrink(string textId, string textName, string textPrice, string textStock, string textVat)
        {
            if (new List<string> { textId, textName, textPrice, textStock, textVat }.Any(x => x == ""))
            {
                throw new Exception("Enter all values!");
            }
            else
            {
                FillDrinkToAdd(textId, textName, textPrice, textStock, textVat);
            }
        }

        private void FillDrinkToAdd(string textId, string textName, string textPrice, string textStock, string textVat)
        {
            int id = int.Parse(textId);
            string name = textName;
            decimal price = decimal.Parse(textPrice);
            int stock = int.Parse(textStock);
            int vat = int.Parse(textVat);

            Drink drink = new(id, name, price, stock, vat);

            drinkdb.AddDrink(id, name, price, stock, vat);
        }

        /*Remove Drinks*/

        public void DeleteDrink(Drink drink)
        {
            drinkdb.DeleteDrink(drink);
        }

        /*Update Drinks*/

        public void UpdateDrink(int id, string name, decimal price, int stock, int vat)
        {
            drinkdb.UpdateDrink(id, name, price, stock, vat);
        }

        public void UpdateDrink(int id, string textName, string textPrice, string textStock, string textVat)
        {
            if (new List<string> { textName, textPrice, textStock, textVat }.Any(x => x == ""))
            {
                throw new Exception("Enter all values!");
            }
            else
            {
                FillDrinkToUpdate(id, textName, textPrice, textStock, textVat);
            }
        }

        private void FillDrinkToUpdate(int id, string textName, string textPrice, string textStock, string textVat)
        {
            string name = textName;
            decimal price = decimal.Parse(textPrice);
            int stock = int.Parse(textStock);
            int vat = int.Parse(textVat);

            Drink drink = new(id, name, price, stock, vat);

            drinkdb.UpdateDrink(id, name, price, stock, vat);
        }
    }
}
