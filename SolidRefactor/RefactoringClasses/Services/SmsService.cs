using SolidRefactor.RefactoringClasses.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidRefactor.RefactoringClasses.Services
{
    internal class SmsService : ISendMessageService
    {
        public void SendMessage(decimal amount)
        {
            Console.WriteLine($"SMS sent for {amount}");
        }
    }
}
