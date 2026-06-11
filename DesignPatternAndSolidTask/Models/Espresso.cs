using DesignPatternAndSolidTask.BuilderPattern;
using DesignPatternAndSolidTask.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternAndSolidTask.Models
{
    internal class Espresso : IBeverage
    {
        public int Quantity { get; set; }
        public Espresso()
        {
            Quantity = 10;
        }
        public decimal GetCost()
        {
            return 100;
        }

        public string GetDescription()
        {
            return "pure Espresso";
        }
    }
}
