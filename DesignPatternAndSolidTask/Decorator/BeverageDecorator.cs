using DesignPatternAndSolidTask.Interfaces;
using DesignPatternAndSolidTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternAndSolidTask.Decorator
{
    internal abstract class BeverageDecorator
    {
        protected IBeverage _beverage;

        protected BeverageDecorator(IBeverage beverage)
        {
            _beverage = beverage;
        }

        public abstract string GetDescription(string extraDescription);
        public abstract decimal GetCost(Order order, decimal extraPrice);
    }
}
