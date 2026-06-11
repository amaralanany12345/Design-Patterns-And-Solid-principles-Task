using DesignPatternAndSolidTask.Enums;
using DesignPatternAndSolidTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternAndSolidTask.ObserverPattern
{
    internal interface IObserver
    {
        void Update(Order order,OrderStatus orderStatus);
    }
}
