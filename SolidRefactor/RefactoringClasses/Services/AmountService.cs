using SolidRefactor.RefactoringClasses.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace SolidRefactor.RefactoringClasses.Services
{
    internal class AmountService : IAmountService
    {
        public void SetMaximumAmountLimit(decimal amount, decimal limitAmount)
        {
            if (amount > limitAmount)
            {
                throw new ArgumentException("ERR: you reach the limit");
            }
        }

        public void SetMinimumAmountLimit(decimal amount, decimal limitAmount)
        {
            if (amount < limitAmount)
            {
                throw new ArgumentException("ERR: bad amount");
            }
        }
    }
}
