using SomerenService;
using System;
using System.Windows.Forms;
using SomerenModel;

namespace SomerenUI
{
    public partial class DrinkUpdateForm : Form
    {
        private string Id { get; set; }
        private string OldName { get; set; }
        private string OldPrice { get; set; }
        private string OldStock { get; set; }
        private string OldVat { get; set; }

        public DrinkUpdateForm(Drink drink)
        {
            Id = drink.Id.ToString();
            OldName = drink.Name;
            OldPrice = drink.Price.ToString();
            OldStock = drink.Stock.ToString();
            OldVat = drink.Vat.ToString();
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                DrinkService drinkService = new();
                drinkService.CheckForUpdates(txtName.Text, txtPrice.Text, txtStock.Text, txtVat.Text, Id, OldName, OldPrice, OldStock, OldVat);

                MessageBox.Show("Drink updated!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong while updating the drink: " + ex.Message);
            }
        }
    }
}
