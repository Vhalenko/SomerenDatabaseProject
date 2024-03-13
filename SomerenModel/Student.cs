using System;

namespace SomerenModel
{
    public class Student
    {
        public int StudentNumber { get; private set; }
        public string FullName { get => $"{FirstName} {LastName}"; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string ClassName { get; private set; }
        public string TelephoneNumber { get; private set; }
        public int RoomNumber { get; private set; }

        public Student(int studentNumber, string firstName, string lastName, string className, string telephoneNumber, int roomNumber)
        {
            StudentNumber = studentNumber;
            FirstName = firstName;
            LastName = lastName;
            ClassName = className;
            TelephoneNumber = telephoneNumber;
            RoomNumber = roomNumber;
        }
    }
}