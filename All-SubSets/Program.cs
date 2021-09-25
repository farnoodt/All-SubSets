using System;
using System.Collections.Generic;
using System.Linq;

namespace All_SubSets
{
    class Program
    {
        static IList<IList<int>> Allsets = new List<IList<int>>();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] arr = { 10, 20, 30, 40, 50 };
            int r = 3;
            int n = arr.Length;

            CombinationUtil(arr);


        }

        static IList<IList<int>> CombinationUtil(int[] candidates)
        {
            for (int i = 0; i <= candidates.Length; i++)
            {
                // A temporary array to store all combination one by one
                int[] data = new int[i];

                // Print all combination using temporary array 'data[]'
                combinationUtil(candidates, i, 0, data, 0);
                //Combination(candidates, i);

            }
            return Allsets;
        }

        static void combinationUtil(int[] arr, int SubsetLen, int index, int[] data, int i )
        {
            int n = arr.Length;
            // Current combination is ready to be printed, print it
            if (index == SubsetLen)
            {
                //for (int j = 0; j < SubsetLen; j++)
                //{
                //    Console.Write(data[j] + " ");

                //}
               
                Allsets.Add(new List<int>(data));
                Console.WriteLine("");
                return;
            }

            // When no more elements are there  to put in data[]
            if (i >= n)
                return;

            // current is included, put next at next location
            data[index] = arr[i];
            combinationUtil(arr, SubsetLen, index + 1, data, i + 1);

            // current is excluded, replace it with next (Note that i+1 is passed, but index is not changed)
            combinationUtil(arr, SubsetLen, index, data, i + 1);
        }

        static void Combination(int[] arr, int SubsetLen)
        {

            
        }
    }
}
