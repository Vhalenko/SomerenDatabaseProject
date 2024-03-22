using SomerenService;
using System;
using System.Windows.Forms;

namespace SomerenUI
{
    public partial class DrinkAddForm : Form
    {
        public DrinkAddForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            try
            {
                DrinkService drinkService = new();

                drinkService.AddDrink(txtId.Text, txtName.Text, txtPrice.Text, txtStock.Text, txtVat.Text);
                MessageBox.Show("Drink added!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong while adding the drink: " + ex.Message);
            }
        }
    }
}
