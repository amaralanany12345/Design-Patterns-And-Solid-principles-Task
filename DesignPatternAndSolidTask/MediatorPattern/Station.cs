using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternAndSolidTask.MediatorPattern
{
    internal abstract class Station
    {
        public IOrderMediator _orderMediator;
        public string Name;
        protected Station(IOrderMediator orderMediator)
        {
            _orderMediator = orderMediator;
        }
        public abstract void Send(string message);
        public abstract void Receive(string message, string fromStationName);
    }
}
