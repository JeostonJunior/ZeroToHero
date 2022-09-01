namespace Encapsulamento
{
    public class EncapsulamentoProduct
    {
        private string _name;
        private double _price;
        private int _quantity;

        public EncapsulamentoProduct() { }

        public EncapsulamentoProduct(string name, double price, int quantity)
        {
            _name = name;
            _price = price;
            _quantity = quantity;
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

        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        // public double GetPrice()
        // {
        //     return _price;
        // }

        // public void SetPrice(double price)
        // {
        //     _price = price;
        // }

        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }
        // public int GetQuantity()
        // {
        //     return _quantity;
        // }

        // public void SetQuantity(int quantity)
        // {
        //     _quantity = quantity;
        // }

        public override string ToString()
        {
            return $"Name: {_name} Price: {_price} Quantity: {_quantity} Amount: {Amount()}";
        }
        public double Amount()
        {
            double amount;
            amount = _price * _quantity;
            return amount;
        }
    }
}