using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass3
{
    public class Bill : IComparable<Bill>
    {
        public int BillNumber { get; set; }
        public DateTime SaleDate { get; set; }
        public HashSet<Item> ItemsSold { get; set; }
        public int TotalAmount { get; set; }

        public Bill(int billNumber, DateTime saleDate)
        {
            BillNumber = billNumber;
            SaleDate = saleDate;
            ItemsSold = new HashSet<Item>();
        }

        public int CompareTo(Bill other)
        {
            return this.BillNumber.CompareTo(other.BillNumber);
        }
    }
}
