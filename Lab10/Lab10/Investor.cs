using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    public class Investor : IObserver
    {
        private string _name;

        public Investor(string name)
        {
            _name = name;
        }

        public void Update(string stockSymbol, double price)
        {
            Console.WriteLine($"Notified {_name} of {stockSymbol}'s change to ${price:F2}");
        }
    }
}
