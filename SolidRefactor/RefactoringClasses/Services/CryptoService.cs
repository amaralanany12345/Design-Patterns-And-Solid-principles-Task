using SolidRefactor.RefactoringClasses.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidRefactor.RefactoringClasses.Services
{
    internal class CryptoService : IOrderTypeService
    {
        public string SetPaymentProcess(decimal amount, ISendMessageService messageService)
        {
            return "not supported yet";
        }
    }
}
