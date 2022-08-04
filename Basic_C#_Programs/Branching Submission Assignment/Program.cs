using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
        Console.WriteLine("Please enter the package weight:");
        string weightStatus = Console.ReadLine();
        int weight = Convert.ToInt32(weightStatus);

        if (weight > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            Console.ReadLine();
            Environment.Exit(0);
        }

        Console.WriteLine("Please enter package width:");
        string widthStatus = Console.ReadLine();
        int width = Convert.ToInt32(widthStatus);

        Console.WriteLine("Please enter the package height:");
        string heightStatus = Console.ReadLine();
        int height = Convert.ToInt32(heightStatus);


        Console.WriteLine("Please enter the package length:");
        string lengthStatus = Console.ReadLine();
        int length = Convert.ToInt32(lengthStatus);

        if (length + width + height > 50)
        {
            Console.WriteLine("Package too big to be shipped via Package Express. Have a good day.");
            Console.ReadLine();
            Environment.Exit(0);

            int firstTotal = width * height * length * weight;
            int finalTotal = firstTotal / 100;

            Console.WriteLine("Your estimated total for shipping this package is $" + finalTotal + ".00");
            Console.WriteLine("Thank you!");
            Console.ReadLine();
        }
    }
}

