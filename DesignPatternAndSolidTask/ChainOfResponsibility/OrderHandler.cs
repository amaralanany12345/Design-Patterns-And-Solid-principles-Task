using DesignPatternAndSolidTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternAndSolidTask.ChainOfResponsibility
{
    internal abstract class OrderHandler
    {
        protected OrderHandler NextHanlder;

        public OrderHandler SetNext(OrderHandler handler)
        {
            NextHanlder = handler;
            return NextHanlder;
        }
        public abstract void HandleOrder(Order order);
    }
}
