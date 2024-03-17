namespace SomerenModel
{
    public class Drink
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public decimal Price { get; private set; }
        public int Stock { get; private set; }
        public string StockToText {  get; private set; }
        public int Vat {  get; private set; }
        public string Alcohol { get => (Vat == 21) ? "alcoholic" : "non-alcoholic"; }

        public Drink(int id, string name, decimal price, int stock, int vat)
        {
            Id = id;
            Name = name;
            Price = price;
            Stock = stock;
            Vat = vat;
        }

        public override string ToString()
        {
            return $"{Name}/{Price}/{Stock}/{Alcohol}";
        }
    }
}
