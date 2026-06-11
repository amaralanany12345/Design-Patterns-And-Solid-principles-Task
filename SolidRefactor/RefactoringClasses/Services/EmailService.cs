using SolidRefactor.RefactoringClasses.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidRefactor.RefactoringClasses.Services
{
    internal class EmailService : ISendMessageService
    {
        public void SendMessage(decimal amount)
        {
            Console.WriteLine($"Email sent for {amount}");
        }
    }
}
