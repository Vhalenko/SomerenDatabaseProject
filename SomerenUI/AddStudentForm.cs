using SomerenDAL;
using SomerenModel;
using SomerenService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SomerenUI
{
    public partial class AddStudentForm : Form
    {
        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void addStudentButton_Click(object sender, EventArgs e)
        {
            try
            {
                AddStudent(new List<string> 
                { studentAddNumberTextbox.Text, studentAddFirstNameTextbox.Text, 
                studentAddLastNameTextbox.Text, studentAddClasstextbox.Text,
                studentAddTelephoneNumberTextbox.Text, studentAddRoomTextbox.Text });

                MessageBox.Show("Student added!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddStudent(List<string> list)
        {
            if (list.Any(x => x == ""))
            {
                throw new Exception("Enter all values!");
            }
            else
            {
                FillStudent(list);
            }
        }

        private void FillStudent(List<string> list)
        {
            int studentNumber = int.Parse(list[0]);
            string firstName = list[1];
            string lastName = list[2];
            string className = list[3];
            string telephoneNumber = list[4];
            int roomNumber = int.Parse(list[5]);

            Student student = new(studentNumber, firstName, lastName, className, telephoneNumber, roomNumber);
            StudentService studentService = new();

            studentService.AddStudent(student);
        }
    }
}
