using System;

namespace NestedLoopsToRecursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            GenerateLoops(arr, 0, n);
        }

        static void GenerateLoops(int[] arr, int index, int n)
        {
            if (index == n)
            {
                Console.WriteLine(string.Join(" ", arr));
                return;
            }

            for (int i = 1; i <= n; i++)
            {
                arr[index] = i;
                GenerateLoops(arr, index + 1, n);
            }
        }
    }
}
