using System;
using System.Collections.Generic;

namespace Ass3
{
    public class Operation
    {
        Dictionary<int, Bill> bills;
        private SortedSet<Bill> sortedBills;

        public Operation()
        {
            bills = new Dictionary<int, Bill>();
            sortedBills = new SortedSet<Bill>();
        }

        public void AddNewBill(int id, DateTime date)
        {
            if (bills.ContainsKey(id))
            {
                Console.WriteLine("Bill already exists");
            }
            else
            {
                Bill newBill = new Bill(id, date);
                sortedBills.Add(newBill);
                bills.Add(id, newBill);
            }
        }

        public void DisplayBill(int id)
        {
            if (bills.ContainsKey(id))
            {
                Console.WriteLine($"Bill Number: {bills[id].BillNumber}, Date of Sale: {bills[id].SaleDate}, Total Amount: {bills[id].TotalAmount}");
                Console.WriteLine("==================");
                Console.WriteLine("Items Sold:");
                foreach (Item item in bills[id].ItemsSold)
                {
                    Console.WriteLine($"Item Code: {item.ItemCode}, Price: {item.Price}, Quantity Sold: {item.QuantitySold}");
                    Console.WriteLine("==================");
                }
            }
            else 
            {
                Console.WriteLine($"Bill with number {id} does not exist.");
            }
        }

        public void DisplayAllBills()
        {
            Console.WriteLine("==================");
            foreach (var bill in sortedBills)
            {
                Console.WriteLine($"Bill Number: {bill.BillNumber}, Date of Sale: {bill.SaleDate}, Total Amount: {bill.TotalAmount}");
            }
            Console.WriteLine("==================");
        }

        public void AddNewItemToBill(int billNumber, string itemCode, int price, int quantity)
        {
            if (bills.ContainsKey(billNumber))
            {
                Item newItem = new Item { ItemCode = itemCode, Price = price, QuantitySold = quantity };

                bool isDuplicate = false;
                foreach (var item in bills[billNumber].ItemsSold)
                {
                    if (item.ItemCode == itemCode)
                    {
                        isDuplicate = true;
                        break;
                    }
                }

                if (isDuplicate)
                {
                    Console.WriteLine($"Error: Item with code {itemCode} already exists in bill {billNumber}.");
                }
                else
                {
                    bills[billNumber].ItemsSold.Add(newItem);
                    bills[billNumber].TotalAmount++;
                    Console.WriteLine($"New item added to bill {billNumber}. Item code: {itemCode}, Price: {price}, Quantity: {quantity}");
                }

            }
            else
            {
                Console.WriteLine($"Bill with number {billNumber} does not exist.");
            }
        }

        public void RemoveItemFromBill(int billNumber, string itemCode)
        {
            if (bills.ContainsKey(billNumber))
            {
                Bill bill = bills[billNumber];
                Item itemToRemove = null;
                foreach (var item in bill.ItemsSold)
                {
                    if (item.ItemCode == itemCode)
                    {
                        itemToRemove = item;
                        break;
                    }
                }
                if (itemToRemove != null)
                {
                    bill.ItemsSold.Remove(itemToRemove);
                    bill.TotalAmount--;
                    Console.WriteLine($"Item with code {itemCode} removed from bill {billNumber}.");
                }
                else
                {
                    Console.WriteLine($"Item with code {itemCode} not found in bill {billNumber}.");
                }
            }
            else
            {
                Console.WriteLine($"Bill with number {billNumber} does not exist.");
            }
        }

        public void UpdateItemQuantity(int billNumber, string itemCode, int newQuantity)
        {
            if (bills.ContainsKey(billNumber))
            {
                Bill bill = bills[billNumber];
                bool itemFound = false;
                foreach (var item in bill.ItemsSold)
                {
                    if (item.ItemCode == itemCode)
                    {
                        item.QuantitySold = newQuantity;
                        itemFound = true;
                        Console.WriteLine($"Quantity of item with code {itemCode} updated to {newQuantity} in bill {billNumber}.");
                        break;
                    }
                }
                if (!itemFound)
                {
                    Console.WriteLine($"Item with code {itemCode} not found in bill {billNumber}.");
                }
            }
            else
            {
                Console.WriteLine($"Bill with number {billNumber} does not exist.");
            }
        }
    }
}
