using DesignPatternAndSolidTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternAndSolidTask.StrategyPattern
{
    internal class NoneStrategy : IDiscountStrategy
    {
        public decimal ApplyDiscount(Order order)
        {
            return order.TotalPrice;
        }
    }
}
