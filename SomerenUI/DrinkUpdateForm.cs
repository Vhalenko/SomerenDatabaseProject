using SomerenService;
using System;
using System.Windows.Forms;
using SomerenModel;

namespace SomerenUI
{
    public partial class DrinkUpdateForm : Form
    {
        private Drink oldDrink;

        public DrinkUpdateForm(Drink drink)
        {
            InitializeComponent();
            oldDrink = drink;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                DrinkService drinkService = new();
                drinkService.CheckForUpdates(txtName.Text, txtPrice.Text, txtStock.Text, txtVat.Text, oldDrink);
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