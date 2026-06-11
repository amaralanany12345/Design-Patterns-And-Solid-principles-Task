using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternAndSolidTask.AbstractFactory
{
    internal class AmericanIngredientFactory : IIngredientFactory
    {
        public IBeans AddBeans()
        {
            return new AmericanBeans();
        }

        public IMilk AddMilk()
        {
            return new AmericanMilk();
        }
    }
}
