using SomerenService;
using System;
using System.Windows.Forms;

namespace SomerenUI
{
    public partial class DrinkUpdateForm : Form
    {
        private int Id { get; set; }

        public DrinkUpdateForm(int id)
        {
            Id = id;
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                DrinkService drinkService = new();
                drinkService.UpdateDrink(Id, txtName.Text, txtPrice.Text, txtStock.Text, txtVat.Text);

                MessageBox.Show("Drink updated!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong while updating the drink: " + ex.Message);
            }
        }
    }
}
