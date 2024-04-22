using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    public interface IObserver
    {
        void Update(string stockSymbol, double price);
    }
}
