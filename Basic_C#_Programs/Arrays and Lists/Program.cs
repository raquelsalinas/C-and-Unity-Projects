using System;
using System.Collections.Generic;

class Program {
    static void Main() {

        string[] pets = new string[] { "Cat", "Dog", "Fish", "Hamster", "Lizard" };
        
        Console.WriteLine("Please select an index of the array between 0 and 4.");
        string inputStatus = Console.ReadLine();
        int input = Convert.ToInt32(inputStatus);

        if (input > 4 || input < 0) {
            Console.WriteLine("Sorry, you picked an index of the array that doesn't exist.");
            Console.ReadLine();
            Environment.Exit(0);
        } else {
            Console.WriteLine("You picked: " + pets[input]);
        }

        Console.WriteLine("Please select an index of the array between 0 and 4.");
        string inputStatus2 = Console.ReadLine();
        int input2 = Convert.ToInt32(inputStatus2);

        int[] numbers = new int[] { 0, 1, 2, 3, 4 };

        if (input2 > 4 || input2 < 0)
        {
            Console.WriteLine("Sorry, you picked an index of the array that doesn't exist.");
            Console.ReadLine();
            Environment.Exit(0);
        }
        else
        {
            Console.WriteLine("You picked: " + numbers[input2]);
        }

        Console.WriteLine("Please select an index of the list between 0 and 4.");
        string inputStatus3 = Console.ReadLine();
        int input3 = Convert.ToInt32(inputStatus3);

        var cities = new List<string>();
        cities.Add("New York");
        cities.Add("London");
        cities.Add("Mumbai");
        cities.Add("Chicago");
        cities.Add("Frankfurt");

        if (input3 > 4 || input3 < 0)
        {
            Console.WriteLine("Sorry, you picked an index of the list that doesn't exist.");
            Console.ReadLine();
            Environment.Exit(0);
        }
        else
        {
            Console.WriteLine("You picked: " + cities[input3]);
            Console.ReadLine();
        }
    }
}

