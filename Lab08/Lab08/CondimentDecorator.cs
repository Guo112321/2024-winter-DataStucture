using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08
{
    public abstract class CondimentDecorator : IBeverage
    {
        protected IBeverage beverage {  get; set; }
        public abstract double GetPrice();


        public CondimentDecorator(IBeverage beverage)
        {
            this.beverage = beverage;
        }
    }
}
