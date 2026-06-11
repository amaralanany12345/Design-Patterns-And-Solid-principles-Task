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
    internal class EspressoDrink : IDrink
    {
        public void Prepare(IBeverage Drink)
        {
            IBeverage newEspresso=new Espresso();
            Console.WriteLine(newEspresso.GetCost());
            Console.WriteLine(newEspresso.GetDescription());
        }
    }
}
