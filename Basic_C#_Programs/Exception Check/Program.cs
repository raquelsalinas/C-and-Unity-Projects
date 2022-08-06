using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> list1 = new List<int>() { 10, 22, 36, 49, 55 };

        while (true)
        {
            try
            {
                Console.WriteLine("Please enter a number to divide all the integers by:");
                string userInputStatus = Console.ReadLine();
                int userInput = Convert.ToInt32(userInputStatus);

                for (int i = 0; i < list1.Count; i++)
                {
                    int divide = list1[i] / userInput;
                    Console.WriteLine(list1[i] + " divided by " + userInput + " equals " + divide);
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please type a whole number.");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please don't divide by zero.");
            }
            
            Console.WriteLine("The program has emerged from the try/catch block and will continue on with program execution.");
        }
    }
}

