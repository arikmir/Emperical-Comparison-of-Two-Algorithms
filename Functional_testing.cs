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
        // THE SOURCE CODE BELOW SHOWS THE FUNCTIONAL CORRECTNESS OF THE MinDistance & MinDistance2 ALGORITHMS, BY APPLYING THEM ON VARIOUS NUMBER OF TEST CASES.
        static void Main(string[] args)
        {
            FunctionalTesting();
            Console.ReadKey();
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
                    {
                        dmin = Math.Abs((A[i] - A[j]));
                    }
                }
            }
            return dmin;
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
        static void FunctionalTesting()
        {
            Console.WriteLine("FUNCTIONALITY CORRECTNESS TESTING");
            Console.WriteLine("----------------------");

            //Array of Consecutive Numbers
            int[] consecutive_arr = new int[] { 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65 };
            double minimum_distance1 = MinDistance(consecutive_arr);
            double minimum_distance2 = MinDistance2(consecutive_arr);

            Console.WriteLine("An array of CONSECUTIVE NUMBERS: { 55,56,57,58,59,60,61,62,63,64,65}");
            Console.WriteLine("Minimum Distance between two elements using Algorithm MinDistance: {0}", minimum_distance1);
            Console.WriteLine("Minimum Distance between two elements using Algorithm MinDistance2: {0}", minimum_distance2);
            Console.WriteLine();

            //Array of Unsorted Numbers
            int[] unsorted_arr = new int[] { 20, 23, 57, 5, 131, 15, 292, 27, 13, 17, 88, 324, 123 };
            double minimum_distance3 = MinDistance(unsorted_arr);
            double minimum_distance4 = MinDistance2(unsorted_arr);

            Console.WriteLine("An array of UNSORTED NUMBERS: { 20, 23, 57, 5, 131, 15, 292, 27, 13, 17 }");
            Console.WriteLine("Minimum Distance between two elements using Algorithm MinDistance: {0}", minimum_distance3);
            Console.WriteLine("Minimum Distance between two elements using Algorithm MinDistance2: {0}", minimum_distance4);
            Console.WriteLine();


            //Array of Sorted Numbers
            int[] sorted_arr = new int[] { 5, 13, 15, 17, 20, 23, 27, 57, 88, 123, 131, 292, 324 };
            double minimum_distance5 = MinDistance(sorted_arr);
            double minimum_distance6 = MinDistance2(sorted_arr);

            Console.WriteLine("An array of SORTED NUMBERS: { 5,13,15,17,20,23,27, 57,88,123,131,292,324 }");
            Console.WriteLine("Minimum Distance between two elements using Algorithm MinDistance: {0}", minimum_distance5);
            Console.WriteLine("Minimum Distance between two elements using Algorithm MinDistance2: {0}", minimum_distance6);
            Console.WriteLine();


            //Array of Reverse Numbers
            int[] reverse_arr = new int[] { 324, 292, 131, 123, 88, 57, 27, 23, 20, 17, 15, 13, 5 };
            double minimum_distance7 = MinDistance(reverse_arr);
            double minimum_distance8 = MinDistance2(reverse_arr);

            Console.WriteLine("An array of SORTED NUMBERS: { 324,292,131,123,88,57,27,23,20,17,15,13,5}");
            Console.WriteLine("Minimum Distance between two elements using Algorithm MinDistance: {0}", minimum_distance7);
            Console.WriteLine("Minimum Distance between two elements using Algorithm MinDistance2: {0}", minimum_distance8);
            Console.WriteLine();

            //Array of Same Digit
            int[] same_arr = new int[] { 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13 };
            double minimum_distance9 = MinDistance(same_arr);
            double minimum_distance10 = MinDistance2(same_arr);

            Console.WriteLine("An array of SAME DIGIT: { 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13 }");
            Console.WriteLine("Minimum Distance between two elements using Algorithm MinDistance: {0}", minimum_distance9);
            Console.WriteLine("Minimum Distance between two elements using Algorithm MinDistance2: {0}", minimum_distance10);
            Console.WriteLine();

            //Partially Sorted Array
            int[] partial_arr = new int[] { 13, 15, 17, 19, 27, 45, 11, 34, 31, 149 };
            double minimum_distance11 = MinDistance(partial_arr);
            double minimum_distance12 = MinDistance2(partial_arr);

            Console.WriteLine("An array of PARTIALLY SORTED: {13, 15, 17, 19, 27, 45, 11, 34, 31, 149}");
            Console.WriteLine("Minimum Distance between two elements using Algorithm MinDistance: {0}", minimum_distance11);
            Console.WriteLine("Minimum Distance between two elements using Algorithm MinDistance2: {0}", minimum_distance12);
            Console.WriteLine();

            //Array consisting of both negative and positve integars
            int[] mixed_arr = new int[] { -99, 19, 17, 78, 2887, 45, -1, 34, -231, -1049 };
            double minimum_distance13 = MinDistance(mixed_arr);
            double minimum_distance14 = MinDistance2(mixed_arr);

            Console.WriteLine("An array of POSITIVE & NEGATIVE INTEGERS: { -99, 19, 17, 78, 2887, 45, -1, 34, -231, -1049}");
            Console.WriteLine("Minimum Distance between two elements using Algorithm MinDistance: {0}", minimum_distance13);
            Console.WriteLine("Minimum Distance between two elements using Algorithm MinDistance2: {0}", minimum_distance14);

            Console.WriteLine();

            //Array consisting of only  negative integars
            int[] negative_arr = new int[] { -23, -99, -735, -44, -4, -1111, -88, -5324, -122, -12 };
            double minimum_distance15 = MinDistance(negative_arr);
            double minimum_distance16 = MinDistance2(negative_arr);

            Console.WriteLine("An array of ONLY NEGATIVE INTEGERS:  -23,-99,-735, -44, -4,-1111,-88, -5324, -122, -12");
            Console.WriteLine("Minimum Distance between two elements using Algorithm MinDistance: {0}", minimum_distance15);
            Console.WriteLine("Minimum Distance between two elements using Algorithm MinDistance2: {0}", minimum_distance16);

            Console.WriteLine();

            //Array consisting of very large and very small numbers
            int[] large_difference_arr = new int[] { 1, 2100000000 };
            double minimum_distance17 = MinDistance(large_difference_arr);
            double minimum_distance18 = MinDistance2(large_difference_arr);

            Console.WriteLine("An array of LARGE and SMALL INTEGERS:  1, 2100000000");
            Console.WriteLine("Minimum Distance between two elements using Algorithm MinDistance: {0}", minimum_distance17);
            Console.WriteLine("Minimum Distance between two elements using Algorithm MinDistance2: {0}", minimum_distance18);

            Console.WriteLine();

            //Array consisting of only one element
            int[] small_arr = new int[] { 1 };
            double minimum_distance19 = MinDistance(small_arr);
            double minimum_distance20 = MinDistance2(small_arr);

            Console.WriteLine("An array of only one INTEGER: 1");
            Console.WriteLine("Minimum Distance between two elements using Algorithm MinDistance: {0}", minimum_distance19);
            Console.WriteLine("Minimum Distance between two elements using Algorithm MinDistance2: {0}", minimum_distance20);
            Console.WriteLine();
        }


    }
}
