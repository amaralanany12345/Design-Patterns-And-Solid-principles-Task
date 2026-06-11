using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternAndSolidTask.Interfaces
{
    internal interface IBeverage
    {
        int Quantity { get; set; }

        decimal GetCost();
        string GetDescription();
    }
}
