using DesignPatternAndSolidTask.Models;
using DesignPatternAndSolidTask.StrategyPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternAndSolidTask.FacadePattern
{
    internal class OrderServiceFacade
    {
        private readonly InventoryService _inventoryService;
        private readonly PaymentServiceFacade _paymentService;
        private readonly NotificationService _notificationService;
        private readonly PricingService _pricingService;
        public OrderServiceFacade(InventoryService inventoryService, PaymentServiceFacade paymentService, NotificationService notificationService, PricingService pricingService)
        {
            _inventoryService = inventoryService;
            _paymentService = paymentService;
            _notificationService = notificationService;
            _pricingService = pricingService;
        }

        public async Task PlaceOrder(Order order)
        {
            _inventoryService.CheckingItemInventory();
            _pricingService.ApplyPayment(order);
            await _paymentService.Pay(order.TotalPrice, "12345");
            _notificationService.AddNotification("completed");
        }
    }
}
