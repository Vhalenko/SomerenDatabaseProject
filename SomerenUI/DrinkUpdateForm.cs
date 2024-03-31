using SomerenService;
using System;
using System.Windows.Forms;
using SomerenModel;
using SomerenDAL;
using System.Collections.Generic;

namespace SomerenUI
{
    public partial class DrinkUpdateForm : Form
    {
        private int Id { get; set; }
        private string DrinkName { get; set; }
        private int Stock { get; set; }
        private decimal Price { get; set; }
        private int Vat { get; set; }

        public DrinkUpdateForm(Drink drink)
        {
            InitializeComponent();
            Id = drink.Id;
            DrinkName = drink.Name;
            Stock = drink.Stock;
            Price = drink.Price;
            Vat = drink.Vat;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                DrinkService drinkService = new();
                Drink drink = CheckForUpdates(txtName.Text, txtPrice.Text, txtStock.Text, txtVat.Text, DrinkName, Price.ToString(), Stock.ToString(), Vat.ToString(), Id.ToString());
                drinkService.UpdateDrink(drink);
                Close();
                MessageBox.Show("Drink updated!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong while updating the drink: " + ex.Message);
            }
        }

        private Drink FillDrinkToUpdate(List<string> list)
        {
            int id = int.Parse(list[0]);
            string name = list[1];
            decimal price = decimal.Parse(list[2]);
            int stock = int.Parse(list[3]);
            int vat = int.Parse(list[4]);

            return new Drink(id, name, price, stock, vat);

        }

        public Drink CheckForUpdates(string filledName, string filledPrice, string filledStock, string filledVat, string oldName, string oldPrice, string oldStock, string oldVat, string id)
        {
            string name = string.IsNullOrWhiteSpace(filledName) ? oldName : filledName;
            string price = string.IsNullOrWhiteSpace(filledPrice) ? oldPrice : filledPrice;
            string stock = string.IsNullOrWhiteSpace(filledStock) ? oldStock : filledStock;
            string vat = string.IsNullOrWhiteSpace(filledVat) ? oldVat : filledVat;
            DrinkService drinkService = new();

             return FillDrinkToUpdate(new List<string> { id, name, price, stock, vat });
        }
    }
}