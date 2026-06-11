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
        public string name;
        protected Station(IOrderMediator orderMediator, string name)
        {
            _orderMediator = orderMediator;
            this.name = name;
        }
        public abstract void send(string message);
        public abstract void receive(string message, string fromStationName);
    }
}
