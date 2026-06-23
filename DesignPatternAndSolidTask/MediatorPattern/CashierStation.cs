using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternAndSolidTask.MediatorPattern
{
    internal class CashierStation : Station
    {
        public CashierStation(IOrderMediator orderMediator) : base(orderMediator)
        {
            Name = "Cashier";
        }

        public override void Receive(string message, string fromStationName)
        {
            Console.WriteLine($"{Name} is received {message} from {fromStationName}");

        }

        public override void Send(string message)
        {
            Console.WriteLine($"{Name} is send {message}");
            _orderMediator.SendMessage(message, this);
        }
    }
}
