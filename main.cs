// Created by: Joanne Santhosh
// Created on: Mar 2022
//
// This program checks eligibility to enter the museum.

using System;

class Program
{
    public static void Main(string[] args)
    {
        var day = Console.ReadLine();
        int age;
        // input
        Console.WriteLine("This program checks eligibility to enter the museum.");
        Console.WriteLine("");
        Console.Write("Enter the day of the week: ");
        day = Console.ReadLine();
        Console.WriteLine("");
        Console.Write("Enter age : ");
        age = Convert.ToInt32(Console.ReadLine());
        // process
        if ((day == "Saturday" || day == "Sunday") || (age > 5 && age < 80))
            Console.WriteLine("You're eligible to enter the museum");
        else
            Console.WriteLine("You are not eligible to enter the museum");
        Console.WriteLine("\nDone.");
    }
}