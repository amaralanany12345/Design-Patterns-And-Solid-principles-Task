using SolidRefactor.RefactoringClasses.Enums;
using SolidRefactor.RefactoringClasses.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidRefactor.RefactoringClasses.Services
{
    internal class ProcessOrderService : IProcessOrderService
    {
        private readonly ILoggingToFileService _loggingToFile;
        private readonly IAmountService _amountService;
        public ProcessOrderService(ILoggingToFileService loggingToFile, IAmountService amountService)
        {
            _loggingToFile = loggingToFile;
            _amountService = amountService;
        }
        public string Process(PaymentType type, decimal amount, ISendMessageService sendMessageService)
        {
            switch (type)
            {
                case PaymentType.crypto:
                    return new CryptoService().SetPaymentProcess(amount, sendMessageService);
                case PaymentType.cash:
                    return new CashService(_loggingToFile).SetPaymentProcess(amount, sendMessageService);
                case PaymentType.card:
                    return new CardService(_loggingToFile,_amountService).SetPaymentProcess(amount, sendMessageService);
                default:
                    return "ERR: unknown payment";
            }
        }
    }
}
