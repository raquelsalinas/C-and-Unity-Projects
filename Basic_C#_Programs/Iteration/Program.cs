using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please input some text: ");
        string userInput = Console.ReadLine();

        List<string> pets = new List<string>() { "cat", "dog", "bird", "fish" };

        foreach (string pet in pets)
        {
            pets.Add(userInput);
        }
        Console.WriteLine(pets);
        Console.ReadLine();
    }
}