using Lab3;
using System;
using System.Collections.Generic;

public class train
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Capacity { get; set; }

    public override string ToString()
    {
        return $"ID: {ID}, name: {Name},  Capacity: {Capacity}";
    }
}

public class program
{
    public static void Main(string[] args)
    {
        //inside this method we will call our logic method from the linked list class

        Linkedlist trainList = new Linkedlist();

        
        trainList.addNewCoachend(new train { ID = 1, Name = "coach1", Capacity = 10 });
        trainList.addNewCoachend(new train { ID = 2, Name = "coach2", Capacity = 20 });

        trainList.Menu();

    }
}