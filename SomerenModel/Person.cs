namespace SomerenModel
{
    public abstract class Person
    {
        public int PersonNumber { get; private set; }
        public string FullName { get => $"{FirstName} {LastName}"; }
        public string FirstName { get; private set; }
        public string LastName { get; private set;}
        public string TelephoneNumber { get; private set; }
        public int RoomNumber { get; private set; }

        public Person (int personNumber, string firstName, string lastName, string telephoneNumber, int roomNumber)
        {
            PersonNumber = personNumber;
            FirstName = firstName;
            LastName = lastName;
            TelephoneNumber = telephoneNumber;
            RoomNumber = roomNumber;
        }
    }
}
