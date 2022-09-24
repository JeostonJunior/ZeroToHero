using Orders.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Orders.Entities
{
    public class Order
    {
        public DateTime Momment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public Client Client { get; set; }


        public Order () { }
        public Order (DateTime momment, OrderStatus status, Client client)
        {
            Momment = momment;
            Status = status;
            Client = client;
        }

        public void AddItem (OrderItem item)
        {
            Items.Add(item);
        }
        public void RemoveItem (OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total ()
        {
            double total = 0.00;
            foreach (OrderItem item in Items)
            {
                total += item.SubTotal();
            }
            return total;
        }

        public override string ToString ()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Order Momment: {Momment.ToString("dd/MM/yyyy HH:mm:ss")}");
            sb.AppendLine($"Order Status: {Status}");
            sb.AppendLine($"Client: {Client}");
            sb.AppendLine("Order Items: ");
            foreach (OrderItem item in Items)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine($"Total Price: $ {Total().ToString("F2", CultureInfo.InvariantCulture)}");
            return sb.ToString();
        }
    }
}
