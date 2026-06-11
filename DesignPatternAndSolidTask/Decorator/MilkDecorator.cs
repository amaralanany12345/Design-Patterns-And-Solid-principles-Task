using DesignPatternAndSolidTask.Interfaces;
using DesignPatternAndSolidTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternAndSolidTask.Decorator
{
    internal class MilkDecorator:BeverageDecorator
    {
        public MilkDecorator(IBeverage beverage) : base(beverage)
        {
        }

        public override decimal GetCost(Order order, decimal extraPrice)
        {
            order.TotalPrice += extraPrice;
            return _beverage.GetCost() + extraPrice;
        }

        public override string GetDescription(string extraDescription)
        {
            return _beverage.GetDescription()+" " + extraDescription;
        }
    }
}
