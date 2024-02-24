using System;

namespace Ass3
{
    class Program
    {
        static void Main(string[] args)
        {
            Operation operation = new Operation();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("=====Menu=====");
                Console.WriteLine("1. Add new bill");
                Console.WriteLine("2. Display bill");
                Console.WriteLine("3. Display all bills");
                Console.WriteLine("4. Add new item to bill");
                Console.WriteLine("5. Remove item from bill");
                Console.WriteLine("6. Update item quantity");
                Console.WriteLine("7. Exit");
                Console.WriteLine("=====Menu=====");
                Console.Write("Enter your choice: ");
                int choice;
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            Console.Write("Enter bill number: ");
                            int billNumber = int.Parse(Console.ReadLine());
                            Console.Write("Enter date of sale (yyyy-MM-dd): ");
                            DateTime date = DateTime.Parse(Console.ReadLine());
                            operation.AddNewBill(billNumber, date);
                            break;
                        case 2:
                            Console.Write("Enter bill number: ");
                            int displayId = int.Parse(Console.ReadLine());
                            operation.DisplayBill(displayId);
                            break;
                        case 3:
                            operation.DisplayAllBills();
                            break;
                        case 4:
                            Console.Write("Enter bill number: ");
                            int billToAdd = int.Parse(Console.ReadLine());
                            Console.Write("Enter item code: ");
                            string itemCodeToAdd = Console.ReadLine();
                            Console.Write("Enter price: ");
                            int priceToAdd = int.Parse(Console.ReadLine());
                            Console.Write("Enter quantity: ");
                            int quantityToAdd = int.Parse(Console.ReadLine());
                            operation.AddNewItemToBill(billToAdd, itemCodeToAdd, priceToAdd, quantityToAdd);
                            break;
                        case 5:
                            Console.Write("Enter bill number: ");
                            int billToRemove = int.Parse(Console.ReadLine());
                            Console.Write("Enter item code to remove: ");
                            string itemCodeToRemove = Console.ReadLine();
                            operation.RemoveItemFromBill(billToRemove, itemCodeToRemove);
                            break;
                        case 6:
                            Console.Write("Enter bill number: ");
                            int billToUpdate = int.Parse(Console.ReadLine());
                            Console.Write("Enter item code to update: ");
                            string itemCodeToUpdate = Console.ReadLine();
                            Console.Write("Enter new quantity: ");
                            int newQuantity = int.Parse(Console.ReadLine());
                            operation.UpdateItemQuantity(billToUpdate, itemCodeToUpdate, newQuantity);
                            break;
                        case 7:
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please enter a number from 1 to 7.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }
        }
    }
}
