using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinDistance2
{
    class Program
    {
        // IMPLEMENTATION OF THE SECOND ALGORITHM
        static void Main(string[] args)
        {
            int[] ex_arr = new int[] { 1, 43, 65, 7654, 35, 32, 3453, 12 };
            Console.WriteLine(MinDistance2(ex_arr));
            Console.ReadLine();
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

                    if (temp < dmin)//++count>0)
                    {
                        dmin = temp;
                    }
                }
            }
            return dmin;


        }
    }
}
