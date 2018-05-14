using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class SortData
    {
        //Parse input into integer array
        public static int[] ParseString(String input)
        {
            try
            {
                String[] integerString = input.Split(' ');
                int[] Data = new int[integerString.Length];
                for (int i = 0; i < Data.Length; i++)
                {
                    Data[i] = int.Parse(integerString[i]);
                }
                return Data;
            }
            //catch if input cannot converted into integer type
            catch (Exception e)
            {
                Console.WriteLine("Data cannot be converted into Integer");
                return null;
            }
        }
        
        //Sort the array and print onto console
        public static void SortAndPrint(ref int[] Data)
        {
            Array.Sort(Data);
            Console.WriteLine("After Sorting: ");
            for (int i = 0; i < Data.Length; i++)
            {
                Console.Write(Data[i] + " ");
            }
            Console.WriteLine("\n");
        }
    }
}
