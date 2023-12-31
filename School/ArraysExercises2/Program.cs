﻿using System.Runtime.InteropServices;

namespace ArraysExercises2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int .Parse(Console.ReadLine());
            switch (input)
            {
                case 1:

                    int num = int.Parse(Console.ReadLine());
                    int[] array1 = new int[num];
                    int sum = 0;
                    for (int i = 0; i < array1.Length; i++)
                    {
                        array1[i] = int.Parse(Console.ReadLine());
                        sum += array1[i];
                    }
                    
                    Console.WriteLine(string.Join(separator:" ", array1));
                    Console.WriteLine(sum);

                    break;
                case 2:
                    int numb = int.Parse(Console.ReadLine());
                    
                    int[] firstElem = new int[numb];
                    int[] SecondElem = new int[numb];

                    for (int i = 1; i <= numb; i++)
                    {
                        int[] array2 = Console.ReadLine().Split(separator:" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                        if (i % 2 == 0)
                        {
                            SecondElem[i - 1] = array2[0];
                            firstElem[i - 1] = array2[1];
                            
                        }
                        else
                        {
                            SecondElem[i - 1] = array2[1];
                            firstElem[i - 1] = array2[0];

                        }
                    }
                    Console.WriteLine(string.Join(separator: " ", firstElem));
                    Console.WriteLine(string.Join(separator: " ", SecondElem));

                    break;
                case 3:
                    int[] array3 = Console.ReadLine()
                        .Split(separator: " ", StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse).ToArray();
                    int Number = int.Parse(Console.ReadLine());
                    for (int i = 0; i < Number;i++)
                    {
                        for (int j = array3.Length - 1 ; j >= 0; j--)
                        {
                            int temp = array3[array3.Length -1];
                            array3[array3.Length -1] = array3[j];
                            array3[j] = temp;
                        }
                    }
                    Console.WriteLine(string.Join(separator: " ", array3));
                    break; 
                case 4:
                    int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

                    for (int i = 0; i < arr.Length - 1 ; i++)
                    {
                        bool greater = true;
                        for (int j = i + 1; j < arr.Length; j++)
                        {
                            if (arr[i] < arr[j])
                            {
                                greater = false;
                                break;
                            }
                        }
                        if (greater)
                        {
                            Console.Write($"{arr[i]} ");
                        }
                    }

                    Console.Write(arr[arr.Length - 1]);
                    break;
                
                case 5:
                    int[] arr1 = Console.ReadLine().Split().Select(int.Parse).ToArray();

                    for (int i = 0; i < arr1.Length; i++)
                    {
                        int n = arr1[i];
                        int leftSum = 0;
                        int rightSum = 0;

                        for (int j = i + 1; j < arr1.Length; j++)
                        {
                            rightSum += arr1[j];
                        }

                        for (int x = 0; x < i; x++)
                        {
                            leftSum += arr1[x];
                        }

                        if (leftSum == rightSum)
                        {
                            Console.WriteLine(i);
                            return;
                        }

                    }

                    Console.WriteLine("no");
                    break;
                case 6:
                    int[] arr2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

                    int bestCount = 0;
                    int bestN = 0;

                    for (int i = 0; i < arr2.Length; i++)
                    {
                        int n = arr2[i];

                        int count = 1;
                        for (int j = i + 1; j < arr2.Length; j++)
                        {
                            if (arr2[j] != n)
                            {
                                break;
                            }

                            count++;
                        }

                        if (bestCount < count)
                        {
                            bestCount = count;
                            bestN = n;
                        }

                    }

                    for (int i = 0; i < bestCount; i++)
                    {
                        Console.Write($"{bestN} ");
                    }

                    break;


            }
        }
    }
}