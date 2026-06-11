using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternAndSolidTask.AdapterPattern
{
    internal interface IPaymentProcessorAdapter
    {
        Task<bool> PayAsync(decimal amount, string cardNumber);
    }
}
