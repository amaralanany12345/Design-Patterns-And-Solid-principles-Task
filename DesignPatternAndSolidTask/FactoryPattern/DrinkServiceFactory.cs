using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternAndSolidTask.FactoryPattern
{
    internal class DrinkServiceFactory : IDrinkFactory
    {
        public IDrink Create(IDrink DrinkType)
        {
            switch(DrinkType)
            {
                case LatteDrink:
                    return new LatteDrink();

                case TeaDrink:
                    return new TeaDrink();

                case EspressoDrink:
                    return new EspressoDrink();
                
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
