using DesignPatternAndSolidTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternAndSolidTask.StrategyPattern
{
    internal interface IDiscountStrategy
    {
        decimal ApplyDiscount(Order order);
    }
}
