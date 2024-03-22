using SomerenService;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Web;
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
                string name = string.IsNullOrWhiteSpace(txtName.Text) ? OldName : txtName.Text;
                string price = string.IsNullOrWhiteSpace(txtPrice.Text) ? OldPrice : txtPrice.Text;
                string stock = string.IsNullOrWhiteSpace(txtStock.Text) ? OldStock : txtStock.Text;
                string vat = string.IsNullOrWhiteSpace(txtVat.Text) ? OldVat : txtVat.Text;
                DrinkService drinkService = new();

                drinkService.UpdateDrink(new List<string> { Id, name, price, stock, vat });

                MessageBox.Show("Drink updated!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong while updating the drink: " + ex.Message);
            }
        }
    }
}
