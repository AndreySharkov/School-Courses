﻿namespace SmallestOfThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            GetSmallestNum(num1, num2, num3);

        }
        static void GetSmallestNum(int num, int num2, int num3) => Console.WriteLine(Math.Min(num, Math.Min(num2, num3)));
    }
}