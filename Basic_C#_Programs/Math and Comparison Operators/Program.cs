﻿using System;

class Program
{
    static void Main() {
        Console.WriteLine("Anonymous Income Comparison Program");

        Console.WriteLine("Person 1");
        Console.WriteLine("What is your hourly rate?");
        string hourStatusOne = Console.ReadLine();
        float hourlyRateOne = Convert.ToSingle(hourStatusOne);

        Console.WriteLine("How many hours do you work a week?");
        string weekStatusOne = Console.ReadLine();
        float hoursPerWeekOne = Convert.ToSingle(weekStatusOne);

        Console.WriteLine("Person 2");
        Console.WriteLine("What is your hourly rate?");
        string hourStatusTwo = Console.ReadLine();
        float hourlyRateTwo = Convert.ToSingle(hourStatusTwo);

        Console.WriteLine("How many hours do you work a week?");
        string weekStatusTwo = Console.ReadLine();
        float hoursPerWeekTwo = Convert.ToSingle(weekStatusTwo);

        float weeksPerYear = 52;

        float weeklySalaryOne = hourlyRateOne * hoursPerWeekOne;
        float annualSalaryOne = weeksPerYear * weeklySalaryOne;

        float weeklySalaryTwo = hourlyRateTwo * hoursPerWeekTwo;
        float annualSalaryTwo = weeksPerYear * weeklySalaryTwo;

        Console.WriteLine("Annual salary of Person 1: $" + annualSalaryOne);
        Console.WriteLine("Annual salary of Person 2: $" + annualSalaryTwo);

        bool greaterThanStatus = annualSalaryOne > annualSalaryTwo;
        string greaterThan = Convert.ToString(greaterThanStatus);

        Console.WriteLine("Does Person 1 make more money than Person 2?");
        Console.WriteLine(greaterThan);
        Console.ReadLine();
    }
}

