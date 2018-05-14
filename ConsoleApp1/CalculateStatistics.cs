using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class CalculateStatistics
    {
        private int[] Data;
        private Double Mean;

        //Constructor to get array data
        public CalculateStatistics(int[] data)
        {
            Data = data;
        }
        
        private Double getMean()
        {
            Double totalData = 0;
            for (int i = 0; i < Data.Length; i++)
            {
                totalData += Data[i];
            }
            Double meanResult = totalData / Data.Length;
            Mean = meanResult;
            return meanResult;
        }

        private int getMedian()
        {
            int medianResult = 0;
            //Check if length is odd or even
            if (Data.Length % 2 == 0)
            {
                int x = (Data.Length / 2) + 1;
                int y = (Data.Length / 2);
                medianResult = (Data[x] + Data[y]) / 2;
                return medianResult;
            }
            else
            {
                int x = (Data.Length / 2);
                medianResult = Data[x];
                return medianResult;
            }
        }

        private Double getSampleVariance()
        {
            Double sigmaX = 0;
            for (int i = 0; i < Data.Length; i++)
            {
                sigmaX += Math.Pow(Data[i] - Mean, 2);
            }
            Double varianceResults = sigmaX / (Data.Length - 1);
            return varianceResults;
        }

        private Double getSampleSD()
        {
            Double sdResults = Math.Sqrt(getSampleVariance());
            return sdResults;
        }

        private Double getPopulationVariance()
        {
            Double sigmaX = 0;
            for (int i = 0; i < Data.Length; i++)
            {
                sigmaX += Math.Pow(Data[i] - Mean, 2);
            }
            Double varianceResults = sigmaX / (Data.Length);
            return varianceResults;
        }

        private Double getPopulationSD()
        {
            Double sdResults = Math.Sqrt(getPopulationVariance());
            return sdResults;
        }

        //Print all results from method, use tab to beautify the results
        public void PrintStatistics()
        {
            Console.WriteLine("Statistics Results ");
            Console.WriteLine("Mean \t\t\t\t : " + getMean());
            Console.WriteLine("Median \t\t\t\t : " + getMedian());
            Console.WriteLine("Sample Standard Deviation \t : " + getSampleSD());
            Console.WriteLine("Sample Variance \t\t : " + getSampleVariance());
            Console.WriteLine("Population Standard Deviation \t : " + getPopulationSD());
            Console.WriteLine("Population Variance \t\t : " + getPopulationVariance());
        }
    }
}
