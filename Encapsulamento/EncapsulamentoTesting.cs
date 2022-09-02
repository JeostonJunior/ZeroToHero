namespace Encapsulamento
{
    public class EncapsulamentoProduct
    {
        private string _name;
        public double Price { get; set; }
        public int Quantity { get; private set; }

        public EncapsulamentoProduct() { }

        public EncapsulamentoProduct(string name, double price, int quantity)
        {
            _name = name;
            Price = price;
            Quantity = quantity;
        }

        ///Novo Metodo de encapsular
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        ///Fim do novo Metodo de encapsular

        ///Metodo antigo de encapsular
        // public string GetName()
        // {
        //     return _name;
        // }

        // public void SetName(string name)
        // {
        //     _name = name;
        // }
        ///Fim do metodo antigo de encapsular

        ///Usando Properties
        // public double Price
        // {
        //     get { return _price; }
        //     set { _price = value; }
        // }

        // public double GetPrice()
        // {
        //     return _price;
        // }

        // public void SetPrice(double price)
        // {
        //     _price = price;
        // }

        public override string ToString()
        {
            return $"Name: {_name} Price: {Price} Quantity: {Quantity} Amount: {Amount()}";
        }
        public double Amount()
        {
            double amount;
            amount = Price * Quantity;
            return amount;
        }
    }
}