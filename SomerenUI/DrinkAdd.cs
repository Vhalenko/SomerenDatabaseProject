using SomerenService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SomerenModel;

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
            if (new List<string> { txtId.Text, txtName.Text, txtPrice.Text, txtStock.Text, txtVat.Text }.Any(x => x == ""))
            {
                MessageBox.Show("Enter all values!");
            }
            else
            {
                try
                {
                    int id = int.Parse(txtId.Text);
                    string name = txtName.Text;
                    decimal price = decimal.Parse(txtPrice.Text);
                    int stock = int.Parse(txtStock.Text);
                    int vat = int.Parse(txtVat.Text);

                    Drink drink = new(id, name, price, stock, vat);
                    DrinkService drinkService = new();
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
}
