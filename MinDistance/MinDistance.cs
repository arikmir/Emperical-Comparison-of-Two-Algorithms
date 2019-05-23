using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinDistance
{
    class Program
    {
        // IMPLEMENTATION OF THE FIRST ALGORITHM
        static void Main(string[] args)
        {
            int[] ex_arr = new int[] { 1, 43, 65, 7654, 35, 32, 3453, 12 };
            Console.WriteLine(MinDistance(ex_arr));
            Console.ReadLine();

        }

        static double MinDistance(int[] A)
        {
            int n = A.Length;
            double dmin = Double.PositiveInfinity;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if ((i != j) && Math.Abs((A[i] - A[j])) < dmin)
                        dmin = Math.Abs((A[i] - A[j]));
                }
            }
            return dmin;
        }

    }
}
