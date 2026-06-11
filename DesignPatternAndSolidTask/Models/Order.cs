using DesignPatternAndSolidTask.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternAndSolidTask.Models
{
    internal class Order
    {
        public List<IBeverage> Beverages { get; set; }=new();
        public decimal TotalPrice { get; set; } 
        public string OrderStatus { get; set; }
        public Customer Customer { get; set; }
        public Order()
        {
            Customer = new Customer
            {
                UserName = "ammar",
                Email = "afckm",
                Age = 22,
                Balance = 2000,
            };
        }
        public void AddItemToOrder(IBeverage beverage)
        {
            Beverages.Add(beverage);
            beverage.Quantity -= 1;
            TotalPrice += beverage.GetCost();
            //Customer.Balance -= beverage.GetCost();
            //Console.WriteLine(Customer.Balance);
        }

    }
}
