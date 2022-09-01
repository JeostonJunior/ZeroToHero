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

        public string GetName()
        {
            return _name;
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public double GetPrice()
        {
            return _price;
        }

        public void SetPrice(double price)
        {
            _price = price;
        }

        public int GetQuantity()
        {
            return _quantity;
        }

        public void SetQuantity(int quantity)
        {
            _quantity = quantity;
        }

        public override string ToString()
        {
            return $"_name: {_name} Price: {_price} Quantity: {_quantity} Amount: {Amount()}";
        }
        public double Amount()
        {
            double amount;
            amount = _price * _quantity;
            return amount;
        }
    }
}