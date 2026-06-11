using DesignPatternAndSolidTask.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternAndSolidTask.ChainOfResponsibility
{
    internal class OrderStockValidator : OrderHandler
    {
        public override void HandleOrder(Order order)
        {
            foreach(var item in order.Beverages)
            {
                if (item.Quantity <=0)
                {
                    throw new ArgumentException("item quantity is not available");
                }
                else if(NextHanlder!=null)
                {
                    Console.WriteLine("quantity is available");
                    NextHanlder.HandleOrder(order);
                }
            }
        }
        
    }
}
