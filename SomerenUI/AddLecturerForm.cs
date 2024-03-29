using SomerenModel;
using SomerenService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SomerenUI
{
    public partial class AddLecturerForm : Form
    {
        public AddLecturerForm()
        {
            InitializeComponent();
            lecturerAddAgeDateTime.Format = DateTimePickerFormat.Custom;
            lecturerAddAgeDateTime.CustomFormat = "dd, MM, yyyy";
        }

        private void addLecturerButton_Click(object sender, EventArgs e)
        {
            List<string> lecturerValues = new() {lecturerAddNumberTextbox.Text, lecturerAddFirstNameTextbox.Text,
                lecturerAddLastNameTextbox.Text, lecturerAddTelephoneNumberTextbox.Text, lecturerAddRoomTextbox.Text};

            try
            {
                AddLecturer(lecturerValues);
                MessageBox.Show("Lecturer added!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private Lecturer FillLecturer(List<string> list)
        {
            int lecturerNumber = int.Parse(list[0]);
            DateTime age = lecturerAddAgeDateTime.Value;
            int roomNumber = int.Parse(list[4]);

            return new Lecturer(lecturerNumber, list[1], list[2], age, list[3], roomNumber);
        }

        private void AddLecturer(List<string> list)
        {
            if (list.Any(x => x == ""))
            {
                throw new Exception("Enter all values!");
            }
            else
            {
                LecturerService lecturerService = new();
                lecturerService.AddLecturer(FillLecturer(list));
                Close();
            }
        }
    }
}
