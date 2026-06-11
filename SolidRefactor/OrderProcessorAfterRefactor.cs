using SolidRefactor.RefactoringClasses.Enums;
using SolidRefactor.RefactoringClasses.Interfaces;
using SolidRefactor.RefactoringClasses.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace SolidRefactor
{
    internal class OrderProcessorAfterRefactor
    {
        private readonly IProcessOrderService _orderService;

        public OrderProcessorAfterRefactor(IProcessOrderService orderService)
        {
            _orderService = orderService;
        }

        
        public string Process(PaymentType type,decimal amount, ISendMessageService sendMessageService)
        {

            return _orderService.Process(type, amount, sendMessageService);
        }
    }
}
