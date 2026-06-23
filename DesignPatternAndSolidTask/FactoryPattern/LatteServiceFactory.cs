using DesignPatternAndSolidTask.Interfaces;
using DesignPatternAndSolidTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternAndSolidTask.FactoryPattern
{
    internal class LatteServiceFactory : IDrinkFactory
    {
        public IDrink Create(IDrink DrinkType)
        {
            IBeverage newLatte = new Latte();
            var latteDrink=new LatteDrink();
            latteDrink.Prepare(newLatte);
            return latteDrink;
        }
    }
}
