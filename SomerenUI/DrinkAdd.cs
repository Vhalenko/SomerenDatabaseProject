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
                int id = int.Parse(txtId.Text);
                string name = txtName.Text;
                decimal price = decimal.Parse(txtPrice.Text);
                int stock = int.Parse(txtStock.Text);
                int vat = int.Parse(txtVat.Text);
                DrinkService drinkService = new DrinkService();
                drinkService.AddDrink(id, name, price, stock, vat);
                MessageBox.Show("Drink added!");
            }
            catch (Exception exeption)
            {
                MessageBox.Show("Something went wrong while adding the drink: " + exeption.Message);
            }
        }
    }
}
