using System;
using System.Configuration;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int iCheckNumber = 0;
            // Fetch Array size from Config file, it could be gotten from User as well, but requires key validation, descoped for now
            int iArraySize = Convert.ToInt32(ConfigurationManager.AppSettings["NumberOfElements"]);
            object[] multipleDTArray = new object[iArraySize];
            Console.WriteLine(string.Format("Please input {0} Array elements to test FizzBuzz program", iArraySize));
            for (int z = 0; z < iArraySize; z++)
            {
                multipleDTArray[z] = Console.ReadLine();
            }
            Console.WriteLine("\nProgram output below:");
            foreach (var i in multipleDTArray)
            {
                iCheckNumber = 0;
                if (int.TryParse(i.ToString(), out iCheckNumber))
                {
                    if (((iCheckNumber % 3) == 0) && (iCheckNumber % 5 != 0))
                    {
                        Console.WriteLine("Fizz");
                    }
                    else if ((iCheckNumber % 5 == 0) && (iCheckNumber % 3 != 0))
                    {
                        Console.WriteLine("Buzz");
                    }
                    else if ((iCheckNumber % 3 == 0) && (iCheckNumber % 5 == 0))
                    {
                        Console.WriteLine("FizzBuzz");
                    }
                    else
                    {
                        Console.WriteLine(string.Format("Divided {0} by {1}", iCheckNumber, 3));
                        Console.WriteLine(string.Format("Divided {0} by {1}", iCheckNumber, 5));
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Item");
                }
            }
            Console.WriteLine("Good bye!");

            Console.ReadKey();
        }
    }
}
