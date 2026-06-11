using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternAndSolidTask.AbstractFactory
{
    internal class Barista
    {
        private readonly IIngredientFactory _ingredientFactory;

        public Barista(IIngredientFactory ingredientFactory)
        {
            _ingredientFactory = ingredientFactory;
        }

        public void Prepare(string milkType,string beansType)
        {
            Console.WriteLine($"Coffee with beans {_ingredientFactory.AddBeans().AddBeansType(beansType)} and milk {_ingredientFactory.AddMilk().AddMilkType(milkType)}");
        }
    }
}
