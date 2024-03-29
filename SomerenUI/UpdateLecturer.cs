using SomerenModel;
using SomerenService;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SomerenUI
{
    public partial class UpdateLecturer : Form
    {
        private Lecturer oldLecturer;

        public UpdateLecturer(Lecturer lecturer)
        {
            InitializeComponent();
            oldLecturer = lecturer;
            lecturerUpdateAgeDateTime.Format = DateTimePickerFormat.Custom;
            lecturerUpdateAgeDateTime.CustomFormat = "dd, MM, yyyy";
            FillBoxesWithOldValues();
            InitializeTextBoxEvent();
        }

        private void updateLecturerButton_Click(object sender, EventArgs e)
        {
            List<string> lecturerValues = new() {lecturerFirstNameTextbox.Text, lecturerLastNameTextbox.Text,
                 lecturerTelephoneNumberTextbox.Text, lecturerRoomNumberTextbox.Text};

            try
            {
                LecturerService lecturerService = new();
                lecturerService.UpdateLecturer(FillLecturer(lecturerValues));
                MessageBox.Show("Lecturer updated!");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private Lecturer FillLecturer(List<string> list)
        {
            int roomNumber = int.Parse(list[3]);
            DateTime age = lecturerUpdateAgeDateTime.Value;

            return new Lecturer(oldLecturer.PersonNumber, list[0], list[1], age, list[2], roomNumber);
        }

        private void FillBoxesWithOldValues()
        {
            lecturerFirstNameTextbox.Text = oldLecturer.FirstName;
            lecturerLastNameTextbox.Text = oldLecturer.LastName;
            lecturerUpdateAgeDateTime.Value = oldLecturer.Age;
            lecturerTelephoneNumberTextbox.Text = oldLecturer.TelephoneNumber;
            lecturerRoomNumberTextbox.Text = oldLecturer.RoomNumber.ToString();
        }

        private void TextBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.Clear();
        }

        private void InitializeTextBoxEvent()
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox)
                {
                    control.MouseDoubleClick += TextBox_MouseDoubleClick;
                }
            }
        }
    }
}
