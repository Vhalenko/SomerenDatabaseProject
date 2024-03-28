using SomerenService;
using System;
using System.Windows.Forms;
using SomerenModel;

namespace SomerenUI
{
    public partial class DrinkUpdateForm : Form
    {
        private int Id { get; set; }
        private string DrinkName { get; set; }
        private int Stock {  get; set; }
        private decimal Price { get; set; }
        private int Vat {  get; set; }

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
                drinkService.CheckForUpdates(txtName.Text, txtPrice.Text, txtStock.Text, txtVat.Text, DrinkName, Price.ToString(), Stock.ToString(), Vat.ToString(), Id.ToString());
                Close();
                MessageBox.Show("Drink updated!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong while updating the drink: " + ex.Message);
            }
        }
    }
}