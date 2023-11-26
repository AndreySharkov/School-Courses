using System;
using System.Collections.Generic;
using System.Linq;
namespace MixedUpLists
{
    internal class Program
    {
        static void Main()
        {
            List<int> list1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> list2 = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> mixedList = MixLists(list1, list2);
            List<int> MaxList = list1.Count > list2.Count ? list1 : list2;
            List<int> result = FilterElements(mixedList, MaxList);

            Console.WriteLine(string.Join(" ", result));
        }

        static List<int> MixLists(List<int> list1, List<int> list2)
        {
            List<int> result = new List<int>();
            int minLength = Math.Min(list1.Count, list2.Count);

            for (int i = 0; i < minLength; i++)
            {
                result.Add(list1[i]);
                result.Add(list2[list2.Count - 1 - i]);
            }
            return result;
        }

        static List<int> FilterElements(List<int> mixedList, List<int> BiggestList)
        {
            int startConstrain = BiggestList[BiggestList.Count - 1];
            int endConstrain = BiggestList[BiggestList.Count - 2];
            List<int> result = new List<int>();
            foreach (int x in mixedList)
            {
                if(x <= Math.Max(startConstrain, endConstrain) && x >= Math.Min(endConstrain, startConstrain))
                {
                    result.Add(x);
                }
            }
            
            result.Sort();

            return result;
        }
    }
}