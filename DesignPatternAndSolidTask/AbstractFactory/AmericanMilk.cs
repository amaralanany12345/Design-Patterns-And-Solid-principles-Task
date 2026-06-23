using DesignPatternAndSolidTask.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternAndSolidTask.AbstractFactory
{
    internal class AmericanMilk : IMilk
    {
        public string AddMilkType()
        {
            return MilkType.AmericanMilk.ToString();
        }
    }
}
