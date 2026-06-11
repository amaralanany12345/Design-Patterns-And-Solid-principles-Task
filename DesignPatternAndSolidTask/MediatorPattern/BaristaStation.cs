using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternAndSolidTask.MediatorPattern
{
    internal class BaristaStation : Station
    {
        public BaristaStation(IOrderMediator orderMediator, string name) : base(orderMediator, name)
        {
        }

        public override void receive(string message, string fromStationName)
        {
            Console.WriteLine($"{name} is received {message} from {fromStationName}");
        }

        public override void send(string message)
        {
            Console.WriteLine($"{name} is send {message}");
            _orderMediator.sendMessage(message, this); 
        }
    }
}
