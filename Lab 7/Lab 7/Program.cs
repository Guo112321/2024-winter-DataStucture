using Lab_7;
using System;

class Program
{
    public static void Main(String[] args)
    {
        Document report = new Report();
        Document resume = new Resume();

        Console.WriteLine("Report:");
        report.DisplayPage();
        Console.WriteLine("Resume:");
        resume.DisplayPage();
    }
}