using DesignPatternAndSolidTask.Enums;
using DesignPatternAndSolidTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternAndSolidTask.ObserverPattern
{
    internal class CustomerAppObserver : IObserver
    {
        public void Update(Order order, OrderStatus orderStatus)
        {
            order.OrderStatus=orderStatus.ToString();
            Console.WriteLine($"order status is {order.OrderStatus.ToString()}");
        }
    }
}
