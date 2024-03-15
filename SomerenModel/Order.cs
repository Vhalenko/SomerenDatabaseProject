using System;

namespace SomerenModel
{
    internal class Order
    {
        private int _Quantity;
        public Student Student { get; private set; }
        public Drink Drink { get; private set; }
        public int Quantity { get => _Quantity; private set => _Quantity = (value > 0) ? value : throw new Exception("Select 1 or more"); }

        public Order (Student student, Drink drink, int quantity)
        {
            Student = student;
            Drink = drink;
            Quantity = quantity;
        }   
    }
}
