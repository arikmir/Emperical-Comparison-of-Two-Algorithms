using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace draft
{
    class Program
    {
        // THE SOURCE CODE BELOW IS THE IMPLEMENTATION FOR CALCULATING THE EXECUTION TIME FOR THE SECOND ALGORITHM. THE RESULTS FROM THIS SOURCE CODE ARE EXPORTED TO A CSV FILE.
        static void Main(string[] args)
        {
            int totalRunningTimes = 20;
            Stopwatch sw = new Stopwatch();
            var csv = new StringBuilder();
            for (int size = 500; size <= 15000; size += 500)
            {
                long totalMilliSecs = 0;
                double averageMilliSecs = 0;
                for (int i = 1; i <= totalRunningTimes; i++)
                {
                    long milliSecs = 0;
                    int[] A = GenerateRandomArray(size);
                    sw.Start();
                    MinDistance2(A);
                    sw.Stop();
                    milliSecs = sw.ElapsedMilliseconds;
                    totalMilliSecs = totalMilliSecs + milliSecs;
                }

                averageMilliSecs = totalMilliSecs * 1.0 / totalRunningTimes;
                Console.WriteLine("Size: " + size + "; Average Running Time (MilliSec)= " + averageMilliSecs);
                var first = size.ToString();
                var second = averageMilliSecs.ToString();
                var newLine = string.Format("{0},{1}", first, second);
                csv.AppendLine(newLine);
            }
            File.WriteAllText(@"C:\Users\Arik\Desktop\CAB 301\algorithm_02.csv", csv.ToString());
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
        static double MinDistance2(int[] arr)
        {
            double dmin = double.PositiveInfinity;
            int n = arr.Length;
            double temp;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    temp = Math.Abs(arr[i] - arr[j]);

                    if (temp < dmin)
                    {
                        dmin = temp;
                    }
                }
            }
            return dmin;

        }


    }
}
