using DesignPatternAndSolidTask.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternAndSolidTask.AbstractFactory
{
    internal class AmericanBeans : IBeans
    {
        public string AddBeansType()
        {
            return BeansType.AmericanBeans.ToString();

        }
    }
}
