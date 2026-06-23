using DesignPatternAndSolidTask.Interfaces;
using DesignPatternAndSolidTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternAndSolidTask.FactoryPattern
{
    internal class EspressoServiceFactory : IDrinkFactory
    {
        public IDrink Create(IDrink DrinkType)
        {
            IBeverage newEspresso = new Espresso();
            var espressoDrink= new EspressoDrink();
            espressoDrink.Prepare(newEspresso);
            return espressoDrink;
        }
    }
}
