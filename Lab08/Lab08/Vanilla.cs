using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08
{
    public class Vanilla : CondimentDecorator
    {
        public Vanilla(IBeverage beverage) : base(beverage)
        {
            this.Beverage = beverage;
        }

        protected IBeverage Beverage { get; set; }

        public override double GetPrice()
        {
            return Beverage.GetPrice() + 0.2;
        }
    }
}
