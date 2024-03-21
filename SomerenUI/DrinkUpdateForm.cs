using SomerenService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomerenUI
{
    public partial class DrinkUpdateForm : Form
    {
        private int Id {  get; set; }
        public DrinkUpdateForm(int id)
        {
            Id = id;
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (new List<string> { txtName.Text, txtPrice.Text, txtStock.Text, txtVat.Text }.Any(x => x == ""))
            {
                MessageBox.Show("Enter all values!");
            }
            else
            {
                try
                {
                    string name = txtName.Text;
                    decimal price = decimal.Parse(txtPrice.Text);
                    int stock = int.Parse(txtStock.Text);
                    int vat = int.Parse(txtVat.Text);

                    DrinkService drinkService = new DrinkService();
                    drinkService.UpdateDrink(Id, name, price, stock, vat);

                    MessageBox.Show("Drink updated!");
                }
                catch (Exception exeption)
                {
                    MessageBox.Show("Something went wrong while adding the drink: " + exeption.Message);
                }
            }
        }
    }
}
