using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Mindistance1_basic_operations
{
    class Program
    {
       // THE SOURCE CODE BELOW IS THE IMPLEMENTAION OF THE CALCULATION OF THE NUMBER OF AVERAGE CASE BASIC OPERATIONS OF THE FIRST ALGORITHM. THE RESULTS ARE EXPORTED TO A CSV FILE
        static void Main(string[] args)
        {
            double count;
            int noOfRuns = 20;
            var csv = new StringBuilder();
            for (int size = 500; size <= 15000; size += 500)
            {

                double totalCounts = 0;
                double averageCount = 0;
                for (int i = 1; i <= noOfRuns; i++)
                {
                    int[] X = GenerateRandomArray(size);
                    double basicOps;
                    count = MinDistance(X, out basicOps);
                    totalCounts = totalCounts + basicOps;
                    averageCount = totalCounts * 1.0 / noOfRuns;
                }
                Console.WriteLine("Size = " + size + "; Average Count = " + totalCounts);

                var first = size.ToString();
                var second = averageCount.ToString();

                var newLine = string.Format("{0},{1}", first, second);
                csv.AppendLine(newLine);
            }

            File.WriteAllText(@"C:\Users\Arik\Desktop\CAB 301\mindistance_basic_operations.csv", csv.ToString());
            Console.ReadKey();
        }

        static int[] GenerateRandomArray(int size)
        {
            int[] A = new int[size];

            int seed = (int)DateTime.Now.Ticks;
            Random rnd = new Random(seed);

            for (int i = 0; i < A.Length; i++)
            {
                A[i] = rnd.Next(Int32.MaxValue);
            }
            return A;
        }

        static double MinDistance(int[] A, out double count)
        {
            count = 0;
            int n = A.Length;
            double dmin = Double.PositiveInfinity;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    count = count + 1;
                    if ( (i!=j) && (Math.Abs((A[i] - A[j])) < dmin))
                    {
                        dmin = Math.Abs((A[i] - A[j]));
                    }
                }
            }

            return dmin;
        }

    }
}
