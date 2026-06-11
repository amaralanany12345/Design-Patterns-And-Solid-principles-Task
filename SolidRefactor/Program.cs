using SolidRefactor.RefactoringClasses;
using SolidRefactor.RefactoringClasses.Enums;
using SolidRefactor.RefactoringClasses.Interfaces;
using SolidRefactor.RefactoringClasses.Services;

namespace SolidRefactor
{
    public class Program
    {
        static void Main()
        {
            ILoggingToFileService loggingToFile=new LoggingToFileService();
            ISendMessageService emailService = new EmailService();
            ISendMessageService smsService = new SmsService();
            IAmountService amountService = new AmountService();
            IOrderTypeService cashService = new CashService(loggingToFile);
            IOrderTypeService cardService = new CardService(loggingToFile, amountService);
            IProcessOrderService processOrderService=new ProcessOrderService(loggingToFile,amountService);
            var orderProcessAfterRefactor = new OrderProcessorAfterRefactor(processOrderService);
            orderProcessAfterRefactor.Process(PaymentType.card, 5000, smsService);
        }
    } 
}