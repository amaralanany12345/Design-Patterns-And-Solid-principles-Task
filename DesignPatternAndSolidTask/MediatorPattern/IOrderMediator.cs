using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternAndSolidTask.MediatorPattern
{
    internal interface IOrderMediator
    {
        void register(Station colleague);
        void sendMessage(string message, Station colleague);
    }
}
