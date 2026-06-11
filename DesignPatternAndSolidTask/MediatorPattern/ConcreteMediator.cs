using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternAndSolidTask.MediatorPattern
{
    internal class ConcreteMediator : IOrderMediator
    {
        private readonly List<Station> _stations=new List<Station>();
        public void register(Station colleague)
        {
            _stations.Add(colleague);
        }

        public void sendMessage(string message, Station colleague)
        {
            foreach (var item in _stations)
            {
                if (item.name != colleague.name)
                {

                    item.receive(message, colleague.name);
                }
            }
        }
    }
}
