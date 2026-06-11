using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidRefactor
{
    internal class OrderProcessor
    {
        public string Process(string type, decimal amount, bool emailReceipt)
        {
            if (amount <= 0) return "ERR: bad amount";

            if (type == "card")
            {
                if (amount > 5000) return "ERR: card limit";
                File.AppendAllText("log.txt", $"CARD {amount} {DateTime.Now}\n");
            }
            else if (type == "cash") { File.AppendAllText("log.txt", $"CASH {amount}\n"); }
            else if (type == "crypto") { return "ERR: not supported yet"; }
            else { return "ERR: unknown payment"; }

            File.WriteAllText($"order_{Guid.NewGuid()}.txt", amount.ToString());

            if (emailReceipt) { Console.WriteLine($"Email sent for {amount}"); }
            else { Console.WriteLine($"SMS sent for {amount}"); }

            return "OK";
        }
    }
}
