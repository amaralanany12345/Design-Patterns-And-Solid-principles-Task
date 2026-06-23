using DesignPatternAndSolidTask.Interfaces;
using DesignPatternAndSolidTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternAndSolidTask.FactoryPattern
{
    internal class TeaServiceFactory : IDrinkFactory
    {
        public IDrink Create(IDrink DrinkType)
        {
            IBeverage newTea = new Tea();
            var teaDrink=new TeaDrink();
            teaDrink.Prepare(newTea);
            return teaDrink;
        }
    }
}
