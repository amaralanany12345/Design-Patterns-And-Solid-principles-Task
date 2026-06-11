using DesignPatternAndSolidTask.BuilderPattern;
using DesignPatternAndSolidTask.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternAndSolidTask.Models
{
    internal class Tea : IBeverage
    {
        public int Quantity { get; set; }
        public Tea()
        {
            Quantity = 10;
        }
        public decimal GetCost()
        {
            return 50;
        }

        public string GetDescription()
        {
            return "pure Tea";

        }
    }
}
