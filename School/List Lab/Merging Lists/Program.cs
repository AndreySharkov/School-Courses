namespace Merging_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> list2 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> Result = MergeArrays(list1, list2);

            if (nums1.Count > nums2.Count)

                resultNums.AddRange(GetRemainingElements(nums1, nums2));
            else if (nums2.Count > nums1.Count)

                resultNums.AddRange(GetRemainingElements(nums2, nums1));

            Console.WriteLine(string.Join(" ", resultNums));

        }
        static List<int> MergeArrays(List<int> list1, List<int> list2)
        {
            List<int> Result = new List<int>();
            int indexToStart;
            if (list1.Count >= list2.Count)
            {
                indexToStart = list1.Count - list2.Count + 3;
                for (int i = 0; i < list2.Count; i++)
                {
                    Result.Add(list1[i]);
                    Result.Add(list2[i]);
                }
                for (int i = indexToStart; i < list1.Count; i++)
                {
                    Result.Add(list1[i]);
                }
            }
            else
            {
                indexToStart = list2.Count - list1.Count + 3;
                for (int j = 0; j < list1.Count; j++)
                {
                    Result.Add(list1[j]);
                    Result.Add(list2[j]);
                }
                for (int i = indexToStart; i < list2.Count; i++)
                {
                    Result.Add(list2[i]);
                }
            }
            return Result;
        }
        List<int> GetRemainingElements(List<int> longerList, List<int> shorterList)
        {

            List<int> nums = new List<int>();

            for (int i = shorterList.Count; i < longerList.Count; i++)
                nums.Add(longerList[i]);

            return nums;

        }

    }
}