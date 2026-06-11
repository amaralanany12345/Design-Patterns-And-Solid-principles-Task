using DesignPatternAndSolidTask.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternAndSolidTask.BuilderPattern
{
    internal class Coffee:IBeverage
    {
        public int Quantity { get; set; }
        public string Size { get; set; }
        public string MilkType { get; set; }
        public int NumberOfShots { get; set; }
        public string SyrupFlavor { get; set; }
        public string WhippedCream { get; set; }
        public string Temperature { get; set; }
        public Coffee()
        {
            Quantity = 10;
        }
        public decimal GetCost()
        {
            return 70m;
        }

        public string GetDescription()
        {
            return "Coffee";
        }
    }
}
