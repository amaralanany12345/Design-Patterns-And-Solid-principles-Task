using DesignPatternAndSolidTask.BuilderPattern;
using DesignPatternAndSolidTask.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternAndSolidTask.FactoryPattern
{
    internal interface IDrink
    {
        void Prepare(IBeverage Drink);
    }
}
