using DesignPatternAndSolidTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternAndSolidTask.ChainOfResponsibility
{
    internal class AgeRestrictedValidator : OrderHandler
    {
        public override void HandleOrder(Order order)
        {
            if (order.Customer.Age <20)
            {
                throw new ArgumentException("you can't got the order");
            }
            else if(NextHanlder !=null) 
            {
                Console.WriteLine("you can got the order");
                NextHanlder.HandleOrder(order);
            }
        }
    }
}
