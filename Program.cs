using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Author: https://github.com/MaxWarman

namespace Fast_Reading_Course_Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
            Console.ForegroundColor = ConsoleColor.White;   // change text color to white
            do
            {
                Console.Clear();

                Console.Write("How many columns (default = 15): ");
                string input = Console.ReadLine();

                int numOfRows;                  // total number of rows
                Random rand = new Random();     // random number generator object

                if (input == "")
                    numOfRows = 15;
                else
                    numOfRows = int.Parse(input);

                int numOfCols = 5 + 2 * numOfRows;  // total number of columns

                Console.WriteLine();
                for (int i = 0; i < numOfRows; i++)
                {
                    Console.Write(i+1 + ".\t");
                    for (int j = 0; j < numOfCols; j++)
                    {
                        if (j == numOfCols / 2)        // write a middle, yellowcollored number
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write(rand.Next(1, 9));
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else if (j == numOfCols / 2 + i + 2 || j == numOfCols / 2 - i - 2)  // write numbers in special distance depending on number of actual row
                        {
                            Console.Write(rand.Next(10, 99));
                        }
                        else
                        {
                            Console.Write("  ");
                        }
                    }
                    Console.Write("\n\n");
                    Console.ReadKey();
                }
                Console.WriteLine("\nPress any key to repeat. Press escape to exit...");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
