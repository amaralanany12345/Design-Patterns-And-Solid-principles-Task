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

        public void Prepare()
        {
            Console.WriteLine($"Coffee with beans {_ingredientFactory.AddBeans().AddBeansType()} and milk {_ingredientFactory.AddMilk().AddMilkType()}");
        }
    }
}
