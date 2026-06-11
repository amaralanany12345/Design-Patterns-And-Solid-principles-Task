using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternAndSolidTask.AdapterPattern
{
    internal class PaymentProcessorAdapterForLegacyPayment : IPaymentProcessorAdapter
    {
        private readonly PaymentProcessorService _paymentService;

        public PaymentProcessorAdapterForLegacyPayment(PaymentProcessorService paymentService)
        {
            _paymentService = paymentService;
        }

        public Task<bool> PayAsync(decimal amount, string cardNumber)
        {
            return Task.FromResult(_paymentService.MakePayment((double)amount, cardNumber));
        }
    }
}
