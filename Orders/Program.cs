using Orders.Entities;
using Orders.Entities.Enums;
using System;

namespace Orders
{
    internal class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth Date (DD/MM/YYYY): ");
            string[] birthDate = Console.ReadLine().Split('/');
            DateTime dateBirth = new DateTime(int.Parse(birthDate[2]), int.Parse(birthDate[1]), int.Parse(birthDate[0]));
            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus orderStatus = (OrderStatus)Enum.Parse(typeof(OrderStatus), Console.ReadLine());

            Client client = new Client(name, email, dateBirth);
            Order order = new Order(DateTime.Now, orderStatus, client);


            Console.Write("How many items to this order? ");
            int totalItems = int.Parse(Console.ReadLine());

            for (int i = 0; i < totalItems; i++)
            {
                Console.WriteLine($"Enter #{i++} item data:");
                Console.Write("Product Name: ");
                string productName = Console.ReadLine();
                Console.Write("Product Price: ");
                double productPrice = double.Parse(Console.ReadLine());
                Console.Write("Quantity: ");
                int productQuantity = int.Parse(Console.ReadLine());


                Product product = new Product(productName, productPrice);
                OrderItem orderItem = new OrderItem(productQuantity, productPrice, product);
                order.AddItem(orderItem);
            }

            Console.WriteLine("ORDER SUMMARY: ");
            Console.WriteLine(order);
        }
    }
}
