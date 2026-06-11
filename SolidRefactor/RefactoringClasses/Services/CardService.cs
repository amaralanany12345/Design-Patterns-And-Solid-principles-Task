using SolidRefactor.RefactoringClasses.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidRefactor.RefactoringClasses.Services
{
    internal class CardService : IOrderTypeService
    {
        private readonly ILoggingToFileService _logToFileService;
        private readonly IAmountService _amountService;
        public CardService(ILoggingToFileService logToFileService, IAmountService amountService)
        {
            _logToFileService = logToFileService;
            _amountService = amountService;
        }

        public string SetPaymentProcess(decimal amount, ISendMessageService messageService)
        {
            _amountService.SetMaximumAmountLimit(amount, 5000);
            _logToFileService.AppendToFile("log.txt", $"CARD {amount} {DateTime.Now}\n");
            _logToFileService.WriteToText($"order_{Guid.NewGuid()}.txt", amount.ToString());
            messageService.SendMessage(amount);
            Console.WriteLine("card");
            return "ok";
        }
    }
}
