using SolidRefactor.RefactoringClasses.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidRefactor.RefactoringClasses.Interfaces
{
    internal interface IProcessOrderService
    {
        public string Process(PaymentType type, decimal amount, ISendMessageService sendMessageService);

    }
}
