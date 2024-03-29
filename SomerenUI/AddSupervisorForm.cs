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
using System.Xml.Linq;

namespace SomerenUI
{
    public partial class AddSupervisorForm : Form
    {
        public AddSupervisorForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                LecturerService lecturerService = new();
                lecturerService.AddLecturer(int.Parse(AddLecNumtxtBox.Text), int.Parse(AddIdtxtBox.Text));
                Close();
                MessageBox.Show("Lecturer added!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong while adding the drink: " + ex.Message);
            }
        }
    }
}
