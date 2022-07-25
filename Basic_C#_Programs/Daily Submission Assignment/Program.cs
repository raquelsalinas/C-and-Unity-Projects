﻿using System;

class Program
{
    static void Main() {
        Console.WriteLine("The Tech Academy");

        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();

        Console.WriteLine("What course are you on?");
        string course = Console.ReadLine();

        Console.WriteLine("What page number are you on?");
        string pageNumberStatus = Console.ReadLine();
        int pageNumber = Convert.ToInt32(pageNumberStatus);

        Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false.\"");
        string helpStatus = Console.ReadLine();
        bool needHelp = Convert.ToBoolean(helpStatus);
        

        Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
        string positiveExperiences = Console.ReadLine();

        Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
        string feedback = Console.ReadLine();

        Console.WriteLine("How many hours did you study today?");
        string hourStatus = Console.ReadLine();
        int hoursStudied = Convert.ToInt32(hourStatus);

        Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
        Console.ReadLine();
    }
}

