using DesignPatternAndSolidTask.AbstractFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternAndSolidTask.MediatorPattern
{
    internal class ConcreteMediator : IOrderMediator
    {
        public void SendMessage(string message, Station station)
        {
            if (station.Name=="Cashier")
            {
                var newBaristaStation = new BaristaStation(this);
                newBaristaStation.Receive(message, station.Name);
            }
            else if (station.Name=="Barista")
            {
                var pickUp=new PickupCounterStation(this);
                pickUp.Receive(message,station.Name);
            }
        }
    }
}
