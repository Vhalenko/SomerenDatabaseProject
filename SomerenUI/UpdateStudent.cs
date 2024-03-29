using SomerenModel;
using SomerenService;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SomerenUI
{
    public partial class UpdateStudent : Form
    {
        private Student oldStudent;

        public UpdateStudent(Student student)
        {
            InitializeComponent();
            oldStudent = student;
            FillBoxesWithOldValues();
            InitializeTextBoxEvent();
        }

        private void updateStudentButton_Click(object sender, EventArgs e)
        {
            List<string> studentValues = new() {studentFirstNameTextbox.Text, studentLastNameTextbox.Text,
                studentClasstextbox.Text, studentTelephoneNumberTextbox.Text, studentRoomNumberTextbox.Text};

            try
            {
                StudentService studentService = new();
                studentService.UpdateStudent(FillStudent(studentValues));
                MessageBox.Show("Student updated!");
                Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private Student FillStudent(List<string> list)
        {
            int roomNumber = int.Parse(list[4]);

            return new Student(oldStudent.PersonNumber, list[0], list[1], list[2], list[3], roomNumber);
        }

        private void FillBoxesWithOldValues()
        {
            studentFirstNameTextbox.Text = oldStudent.FirstName;
            studentLastNameTextbox.Text = oldStudent.LastName;
            studentClasstextbox.Text = oldStudent.ClassName;
            studentTelephoneNumberTextbox.Text = oldStudent.TelephoneNumber;
            studentRoomNumberTextbox.Text = oldStudent.RoomNumber.ToString();
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