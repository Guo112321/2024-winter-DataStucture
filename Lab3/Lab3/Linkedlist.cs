using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Linkedlist
    {
        private Node head;
        public Linkedlist()
        {
            this.head = null;
        }

        //All the laberquired method or functions will be created here

        public void addNewCoachfront(train train)
        {
            Node newNode = new Node(train);
            newNode.Next = head;
            head = newNode;
        }

        public void addNewCoachend(train train)
        {
            Node newNode = new Node(train);

            if (head == null)
            {
                head = newNode;
                return;
            }

            Node currendNode = head;
            while (currendNode.Next != null)
            {
                currendNode = currendNode.Next;
            }

            currendNode.Next = newNode;
        }

        public void addNewCoachBefore(train train, int i)
        {
            Node newNode = new Node(train);

            Node currentNode = head;

            if (i == head.Data.ID)
            {
                addNewCoachfront(train);
                return;
            }

            while (i != currentNode.Next.Data.ID)
            {
                currentNode = currentNode.Next;
            }
            newNode.Next = currentNode.Next;
            currentNode.Next = newNode;

        }

        public void addNewCoachAfter(train train, int i)
        {
            Node newNode = new Node(train);

            Node currentNode = head;

            while (i != currentNode.Data.ID)
            {
                currentNode = currentNode.Next;
            }
            newNode.Next = currentNode.Next;
            currentNode.Next = newNode;
        }

        public void removeCoachById(int i)
        {
            Node currentNode = head;

            if (currentNode.Data.ID == i)
            {
                head = currentNode.Next;
                return;
            }

            while (i != currentNode.Next.Data.ID)
            {
                currentNode = currentNode.Next;

                if (currentNode.Next == null)
                {
                    Console.WriteLine("Cannot find coach by id:" + i);
                    return;
                }
            }

            currentNode.Next = currentNode.Next.Next;
        }

        public void removeCoachBefore(int i)
        {
            Node currentNode = head;

            if (currentNode.Data.ID == i)
            {
                Console.WriteLine(i + "Coach is first coach, cannot remove coach before him");
                return;
            }
            else if (currentNode.Next.Data.ID == i)
            {
                head = currentNode.Next;
                return;
            }

            while (i != currentNode.Next.Next.Data.ID)
            {
                currentNode = currentNode.Next;

                if (currentNode.Next.Next == null)
                {
                    Console.WriteLine("Cannot find coach by id:" + i);
                    return;
                }
            }

            currentNode.Next = currentNode.Next.Next;
        }

        public void removeCoachAfter(int i)
        {
            Node currentNode = head;

            while (i != currentNode.Data.ID)
            {
                currentNode = currentNode.Next;

                if (currentNode == null)
                {
                    Console.WriteLine("Cannot find coach by id:" + i);
                    return;
                }
            }

            if (currentNode.Next == null)
            {
                Console.WriteLine(i + "Coach is last coach, cannot remove coach after him");
                return;
            }

            currentNode.Next = currentNode.Next.Next;
        }

        public void printLinkedList()
        {
            Console.WriteLine("----------------");
            if (head == null)
            {
                Console.WriteLine("null");
                return;
            }

            Node currentNode = head;

            while (currentNode != null)
            {
                Console.WriteLine(currentNode.Data.ToString());
                currentNode = currentNode.Next;
            }

            Console.WriteLine("----------------");

        }

        public void Menu()
        {
            while (true)
            {
                Console.WriteLine("\n==== Linked List Menu ====");
                Console.WriteLine("1. Add new coach to the front");
                Console.WriteLine("2. Add new coach to the end");
                Console.WriteLine("3. Add new coach before a specific coach ID");
                Console.WriteLine("4. Add new coach after a specific coach ID");
                Console.WriteLine("5. Remove coach by ID");
                Console.WriteLine("6. Remove coach before a specific coach ID");
                Console.WriteLine("7. Remove coach after a specific coach ID");
                Console.WriteLine("8. Print linked list");
                Console.WriteLine("9. Exit");

                Console.Write("Enter your choice (1-9): ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter coach ID: ");
                        int Id = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter coach name:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter coach capicity:");
                        int capicity = int.Parse(Console.ReadLine());
                        addNewCoachfront(new train { ID = Id, Name = name , Capacity = capicity});
                        break;

                    case "2":
                        Console.Write("Enter coach ID: ");
                        int Id2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter coach name:");
                        string name2 = Console.ReadLine();
                        Console.WriteLine("Enter coach capicity:");
                        int capicity2 = int.Parse(Console.ReadLine());
                        addNewCoachend(new train { ID = Id2, Name = name2, Capacity = capicity2 });
                        break;

                    case "3":
                        Console.Write("Enter new coach ID: ");
                        int Id3 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter coach name:");
                        string name3 = Console.ReadLine();
                        Console.WriteLine("Enter coach capicity:");
                        int capicity3 = int.Parse(Console.ReadLine());
                        Console.Write("Enter existing coach ID before which to add: ");
                        int existingIdBefore = int.Parse(Console.ReadLine());
                        addNewCoachBefore(new train { ID = Id3, Name = name3, Capacity = capicity3 }, existingIdBefore);
                        break;

                    case "4":
                        Console.Write("Enter new coach ID: ");
                        int Id4 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter coach name:");
                        string name4 = Console.ReadLine();
                        Console.WriteLine("Enter coach capicity:");
                        int capicity4 = int.Parse(Console.ReadLine());
                        Console.Write("Enter existing coach ID after which to add: ");
                        int existingIdAfter = int.Parse(Console.ReadLine());
                        addNewCoachAfter(new train { ID = Id4, Name = name4, Capacity = capicity4 }, existingIdAfter);
                        break;

                    case "5":
                        Console.Write("Enter coach ID to remove: ");
                        int removeId = int.Parse(Console.ReadLine());
                        removeCoachById(removeId);
                        break;

                    case "6":
                        Console.Write("Enter coach ID before which to remove: ");
                        int removeBeforeId = int.Parse(Console.ReadLine());
                        removeCoachBefore(removeBeforeId);
                        break;

                    case "7":
                        Console.Write("Enter coach ID after which to remove: ");
                        int removeAfterId = int.Parse(Console.ReadLine());
                        removeCoachAfter(removeAfterId);
                        break;

                    case "8":
                        printLinkedList();
                        break;

                    case "9":
                        Console.WriteLine("Exiting program. Goodbye!");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 9.");
                        break;
                }
            }

        }
    }
}
