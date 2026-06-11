using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternAndSolidTask.SingletonPattern
{
    internal class ShopConfiguration
    {
        private static ShopConfiguration instance;
        private static readonly object lockThread = new object();
        public static ShopConfiguration GetInstance()
        {
            lock (lockThread)
            {
                if (instance == null)
                {
                    instance = new ShopConfiguration();
                }
                return instance;
            }
        }
        public decimal TaxRate { get; }
        public string Currency { get; }
        public int OpeningHours { get; }
        private ShopConfiguration()
        {
            TaxRate = 0.14m;
            Currency = "USD";
            OpeningHours = 6;
        }
    }
}
