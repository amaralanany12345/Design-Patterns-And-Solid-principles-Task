using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternAndSolidTask.AbstractFactory
{
    internal class EuropeanIngredientFactory : IIngredientFactory
    {
        public IBeans AddBeans()
        {
            return new EuropeanBeans();
        }

        public IMilk AddMilk()
        {
            return new EuropeanMilk();
        }
    }
}
