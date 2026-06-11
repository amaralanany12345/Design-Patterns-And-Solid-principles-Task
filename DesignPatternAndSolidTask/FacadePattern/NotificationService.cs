using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternAndSolidTask.FacadePattern
{
    internal class NotificationService
    {

        public void AddNotification(string notification)
        {
            Console.WriteLine($"notification is {notification}");
        }
    }
}
