using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Drink
    {
        public int ID { get; private set; }
        public string Name { get; private set; }
        public decimal Price { get; private set; }
        public string Stock {  get; private set; }
        public int Vat {  get; private set; }

        public Drink(int id, string name, decimal price, string stock, int vat)
        {
            ID = id;
            Name = name;
            Price = price;
            Stock = stock;
            Vat = vat;
        }
    }
}
