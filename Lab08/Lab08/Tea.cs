using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08
{
    public class Tea : IBeverage
    {
        public Tea() { }
        public double GetPrice()
        {
            return 2.99;
        }
    }
}
