using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DaysoftheWeek theDays = new DaysoftheWeek();
                Console.WriteLine("Please type the day of the week.");
                string userInput = Console.ReadLine();

                var day = (Days)Enum.Parse(typeof(Days), userInput);

                Console.WriteLine("Today is {0}. ", (Days)Enum.Parse(typeof(Days), userInput));
                Console.ReadLine();
            }
            catch (SystemException e)
            {
                Console.WriteLine("Please enter an actual day of the week. Thank you.");
                Console.ReadLine();
                return;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
