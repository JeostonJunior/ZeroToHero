namespace UsingDirectory.Entities
{
    internal class Product
    {
        public string Name { get; set; }
        public double Value { get; set; }
        public int Quantity { get; set; }

        public Product (string name, double value, int quantity)
        {
            Name = name;
            Value = value;
            Quantity = quantity;
        }

        public double TotalValue ()
        {
            return Value * Quantity;
        }
    }
}
