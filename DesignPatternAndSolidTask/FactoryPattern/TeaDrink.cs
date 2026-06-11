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
    internal class TeaDrink:IDrink
    {
        public void Prepare(IBeverage Drink)
        {
            IBeverage newTea= new Tea();
            Console.WriteLine(newTea.GetCost());
            Console.WriteLine(newTea.GetDescription());
        }
    }
}
