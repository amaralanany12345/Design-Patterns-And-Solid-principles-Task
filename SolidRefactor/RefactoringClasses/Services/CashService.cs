using SolidRefactor.RefactoringClasses.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidRefactor.RefactoringClasses.Services
{
    internal class CashService : IOrderTypeService
    {
        private readonly ILoggingToFileService _loggingToFile;
        public CashService(ILoggingToFileService loggingToFile)
        {
            _loggingToFile = loggingToFile;
        }

        public string SetPaymentProcess(decimal amount, ISendMessageService messageService)
        {
            _loggingToFile.AppendToFile("log.txt", $"CASH {amount}\n");
            _loggingToFile.WriteToText($"order_{Guid.NewGuid()}.txt", amount.ToString());
            messageService.SendMessage(amount);
            Console.WriteLine("cash");
            return "ok";
        }
    }
}
