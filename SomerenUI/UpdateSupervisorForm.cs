using SomerenModel;
using SomerenService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SomerenUI
{
    public partial class UpdateSupervisorForm : Form
    {
        private int SupervisorNumber { get; set; }
        public UpdateSupervisorForm(Lecturer lecturer)
        {
            InitializeComponent();
            SupervisorNumber = lecturer.PersonNumber;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                LecturerService lecturerService = new();
                lecturerService.UpdateLecturer(int.Parse(SupervisorsNumtxtBox.Text), int.Parse(NewActivitytxtBox.Text));
                Close();
                MessageBox.Show("Supervisor updated!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong while updating the drink: " + ex.Message);
            }
        }
    }
}
