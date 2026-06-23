using DesignPatternAndSolidTask.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternAndSolidTask.AbstractFactory
{
    internal class EuropeanMilk : IMilk
    {
        public string AddMilkType()
        {
            return MilkType.EuropeanMilk.ToString();

        }
    }
}
