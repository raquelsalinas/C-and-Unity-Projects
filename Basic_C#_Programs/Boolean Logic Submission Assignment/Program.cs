using System;

class Program {
    static void Main() {
        Console.WriteLine("What is your age?");
        string ageStatus = Console.ReadLine();
        int age = Convert.ToInt32(ageStatus);

        Console.WriteLine("Have you ever had a DUI? Please answer with true or false.");
        string DUI = Console.ReadLine();
        DUI.ToLower();

        Console.WriteLine("How many speeding tickets do you have?");
        string ticketStatus = Console.ReadLine();
        int ticket = Convert.ToInt32(ticketStatus);

        bool qualified = (age >= 15 && DUI == "false" && ticket <= 3);
        Console.WriteLine("Qualified?");
        Console.WriteLine(qualified);
        Console.ReadLine();
        }
}

