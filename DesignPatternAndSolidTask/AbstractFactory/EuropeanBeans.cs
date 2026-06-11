using DesignPatternAndSolidTask.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternAndSolidTask.AbstractFactory
{
    internal class EuropeanBeans : IBeans
    {
        public string AddBeansType(string beansType)
        {
            return BeansType.EuropeanBeans.ToString();
        }
    }
}
