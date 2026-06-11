using DesignPatternAndSolidTask.BuilderPattern;
using DesignPatternAndSolidTask.Interfaces;
using DesignPatternAndSolidTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternAndSolidTask.FactoryPattern
{
    internal class LatteDrink : IDrink
    {
        public void Prepare(IBeverage Drink)
        {
            IBeverage newLatte= new Latte();
            Console.WriteLine(newLatte.GetCost());
            Console.WriteLine(newLatte.GetDescription());
        }
    }
}
