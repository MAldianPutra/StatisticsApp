using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Input the data : ");
            String userInput = Console.ReadLine();

            //Parse Data to Int array
            int[] Data = SortData.ParseString(userInput);
            //Check Data 
            if (Data == null)
            {
                Console.WriteLine("Program Stopped.");
            }
            else
            {
                //Sorting int array to ascending and print onto console
                SortData.SortAndPrint(ref Data);
                //Calculate the Statistics and print onto console
                CalculateStatistics calculateStatistics = new CalculateStatistics(Data);
                calculateStatistics.PrintStatistics();
            }
            Console.ReadLine();
        }
    }
}
