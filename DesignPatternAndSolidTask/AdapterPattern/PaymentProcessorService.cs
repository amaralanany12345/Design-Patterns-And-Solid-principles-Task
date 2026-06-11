using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternAndSolidTask.AdapterPattern
{
    internal class PaymentProcessorService
    {
        public bool MakePayment(double amountInCents, string cardHash)
        {
            return true;
        }

    }
}
