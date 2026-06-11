using DesignPatternAndSolidTask.Interfaces;
using DesignPatternAndSolidTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternAndSolidTask.ChainOfResponsibility
{
    internal class CustomerPaymentValidator : OrderHandler
    {
        public override void HandleOrder(Order order)
        {
            if(order.TotalPrice>order.Customer.Balance)
            {
                throw new ArgumentException("your balance is not enough");
            }
            else if (NextHanlder!=null)
            {
                Console.WriteLine("your balance is enough");
                order.Customer.Balance -= order.TotalPrice;
                NextHanlder.HandleOrder(order);
            }
        }
    }
}
