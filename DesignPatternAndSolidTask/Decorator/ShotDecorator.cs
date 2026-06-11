using DesignPatternAndSolidTask.Interfaces;
using DesignPatternAndSolidTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternAndSolidTask.Decorator
{
    internal class ShotDecorator : BeverageDecorator
    {
        public ShotDecorator(IBeverage beverage) : base(beverage)
        {
        }

        public override decimal GetCost(Order order, decimal extraPrice)
        {
            order.TotalPrice += extraPrice;
            return _beverage.GetCost() + extraPrice;
        }

        public override string GetDescription(string extraDescription)
        {
            return _beverage.GetDescription() + " " + extraDescription;
        }
    }
}
