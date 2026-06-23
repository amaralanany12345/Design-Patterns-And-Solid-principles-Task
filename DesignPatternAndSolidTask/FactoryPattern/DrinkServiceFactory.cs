using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternAndSolidTask.FactoryPattern
{
    internal class DrinkServiceFactory : IDrinkServiceFactory
    {
        public IDrinkFactory CreateDrinkFactory(IDrink drink)
        {
            switch(drink)
            {
                case LatteDrink:
                    var latteServiceFactory= new LatteServiceFactory();
                    latteServiceFactory.Create(drink);
                    return latteServiceFactory;

                case TeaDrink:
                    var teaServiceFactory = new TeaServiceFactory();
                    teaServiceFactory.Create(drink);
                    return teaServiceFactory;

                case EspressoDrink:
                    var espressoServiceFactory = new EspressoServiceFactory();
                    espressoServiceFactory.Create(drink);
                    return espressoServiceFactory;

                default:
                    throw new NotImplementedException();
            }
        }
    }
}
