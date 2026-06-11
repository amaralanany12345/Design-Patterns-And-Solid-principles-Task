using DesignPatternAndSolidTask.Enums;
using DesignPatternAndSolidTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternAndSolidTask.StrategyPattern
{
    internal class PricingService
    {
        private IDiscountStrategy DiscountStrategy;
        public DiscountType DiscountType { get; set; }
        public void ApplyPayment(Order order)
        {
            switch (DiscountType)
            {
                case DiscountType.None:
                    DiscountStrategy = new NoneStrategy();
                    order.TotalPrice=DiscountStrategy.ApplyDiscount(order);
                    break;
                case DiscountType.PercentageOff:
                    DiscountStrategy = new PercentageOffStrategy();
                    order.TotalPrice = DiscountStrategy.ApplyDiscount(order);
                    break;
                case DiscountType.OneGetOneStrategy:
                    DiscountStrategy = new BuyOneGetOneStrategy();
                    order.TotalPrice =DiscountStrategy.ApplyDiscount(order);
                    break;
            }
        }
    }
}


