using DesignPatternAndSolidTask.AdapterPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternAndSolidTask.FacadePattern
{
    internal class PaymentServiceFacade
    {
        private readonly IPaymentProcessorAdapter _adapter;

        public PaymentServiceFacade(IPaymentProcessorAdapter adapter)
        {
            _adapter = adapter;
        }

        public async Task<bool> Pay(decimal amount, string cardNumber)
        {
            return await _adapter.PayAsync(amount, cardNumber);
        }
    }
}
