using System;
using System.Collections.Generic;

class Program
{
    static HashSet<int> Set_1 = new HashSet<int>();
    static HashSet<int> Set_2 = new HashSet<int>();
    static HashSet<int> Set_3 = new HashSet<int>();

    static void Main(string[] args)
    {
        int choice;
        do
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine("1. Create three sets: ");
            Console.WriteLine("2. Display all three sets");
            Console.WriteLine("3. Exclude common elements" +
                "");
            Console.WriteLine("4. Display common elements");
            Console.WriteLine("5. Display combined elements");
            Console.WriteLine("6. Display unique elements in Set_1");
            Console.WriteLine("7. Exit");
            Console.Write("Enter your choice here (select from 1-7): ");

            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Please enter a number.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    CreateSets();
                    break;
                case 2:
                    DisplaySets();
                    break;
                case 3:
                    ExcludeCommonElements();
                    break;
                case 4:
                    DisplayCommonElements();
                    break;
                case 5:
                    DisplayCombinedElements();
                    break;
                case 6:
                    DisplayUniqueElementsInSet1();
                    break;
                case 7:
                    Console.WriteLine("Exiting...");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 7.");
                    break;
            }
        } while (choice != 7);
    }

    static void CreateSets()
    {
        Set_1.Clear();
        Set_2.Clear();
        Set_3.Clear();

        Console.WriteLine("Please Enter elements for Set_1 (separate by comma):");
        string[] set_1Input = Console.ReadLine().Split(',');
        foreach (var item in set_1Input)
        {
            int num;
            if (int.TryParse(item, out num))
            {
                Set_1.Add(num);
            }
        }

        Console.WriteLine("Please Enter elements for Set_2 (separate by comma):");
        string[] set_2Input = Console.ReadLine().Split(',');
        foreach (var item in set_2Input)
        {
            int num;
            if (int.TryParse(item, out num))
            {
                Set_2.Add(num);
            }
        }

        Console.WriteLine(" Please Enter elements for Set_3 (separate by comma):");
        string[] set_3Input = Console.ReadLine().Split(',');
        foreach (var item in set_3Input)
        {
            int num;
            if (int.TryParse(item, out num))
            {
                Set_3.Add(num);
            }
        }

        Console.WriteLine("Sets created successfully.");
    }

    static void DisplaySets()
    {
        Console.WriteLine("Set_1: {" + string.Join(", ", Set_1) + "}");
        Console.WriteLine("Set_2: {" + string.Join(", ", Set_2) + "}");
        Console.WriteLine("Set_3: {" + string.Join(", ", Set_3) + "}");
    }

    static void ExcludeCommonElements()
    {
        HashSet<int> commonE = new HashSet<int>(Set_1);
        commonE.IntersectWith(Set_2);
        commonE.IntersectWith(Set_3);

        Set_1.ExceptWith(commonE);
        Set_2.ExceptWith(commonE);
        Set_3.ExceptWith(commonE);
        Console.WriteLine("Exclude successfully");
    }

    static void DisplayCommonElements()
    {
        HashSet<int> TestHs = new HashSet<int>(Set_1);
        TestHs.IntersectWith(Set_2);
        TestHs.IntersectWith(Set_3);
        Console.WriteLine("Common Elements: {" + string.Join(", ", TestHs) + "}");
    }

    static void DisplayCombinedElements()
    {
        HashSet<int> TestHs = new HashSet<int>(Set_1);
        TestHs.UnionWith(Set_2);
        TestHs.UnionWith(Set_3);
        Console.WriteLine("Combined Elements: {" + string.Join(", ", TestHs) + "}");
    }

    static void DisplayUniqueElementsInSet1()
    {
        HashSet<int> TestHs = new HashSet<int>(Set_1);
        TestHs.ExceptWith(Set_2);
        TestHs.ExceptWith(Set_3);

        Console.WriteLine("Unique Elements in Set_1: {" + string.Join(", ", TestHs) + "}");
    }


}


