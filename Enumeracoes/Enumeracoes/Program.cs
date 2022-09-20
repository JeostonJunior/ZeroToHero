using Enumeracoes.Entities;
using Enumeracoes.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeracoes
{
    internal class Program
    {
        static void Main (string[] args)
        {
            Order order = new Order
            {
                Id = 1000,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            //Int em string, enum em string
            string text = OrderStatus.PendingPayment.ToString();

            //outra forma de imprimir
            OrderStatus os = (OrderStatus)Enum.Parse(typeof(OrderStatus), "Delivered");

            Console.WriteLine(text);

            Console.WriteLine(os);


        }
    }
}
