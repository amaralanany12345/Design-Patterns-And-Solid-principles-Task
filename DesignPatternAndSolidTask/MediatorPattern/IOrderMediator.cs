using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternAndSolidTask.MediatorPattern
{
    internal interface IOrderMediator
    {
        void SendMessage(string message, Station station);
    }
}
