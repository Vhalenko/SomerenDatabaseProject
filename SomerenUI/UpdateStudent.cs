using SomerenModel;
using SomerenService;
using System;
using System.Windows.Forms;

namespace SomerenUI
{
    public partial class StudentUpdate : Form
    {
        private Student oldStudent;

        public StudentUpdate(Student student)
        {
            InitializeComponent();
            oldStudent = student;
        }

        private void updateStudentButton_Click(object sender, EventArgs e)
        {
        }

        private Student CreateUpdatedStudent()
        {
            return new Student(
                oldStudent.PersonNumber,
                studentFirstNameTextbox.Text,
                studentLastNameTextbox.Text,
                studentClasstextbox.Text,
                studentTelephoneNumberTextbox.Text,
                string.IsNullOrEmpty(studentRoomNumberTextbox.Text) ? int.Parse(null) : int.Parse(studentRoomNumberTextbox.Text));
        }
    }
}
