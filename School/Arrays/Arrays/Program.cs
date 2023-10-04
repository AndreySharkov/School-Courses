namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
                    int days = int.Parse(Console.ReadLine());


                    if (days >= 1 && days <= 7)
                    {
                        Console.WriteLine(daysOfWeek[days - 1]);
                    }
                    else
                    {
                        Console.WriteLine("Invalid day!");
                    }
                    
                    break;
                case "2":
                    int n = int.Parse(Console.ReadLine());
                    int[] arr = new int[n];

                    for (int i = 0; i < n; i++)
                    {
                        arr[i] = int.Parse(Console.ReadLine());
                    }

                    
                    for (int j = arr.Length - 1; j >= 0 ; j--)
                    {
                        Console.Write(arr[j] + " ");
                    }

                            

                        break;
                case "3":
                    double[] NUmbers = Console.ReadLine()
                        .Split(separator:" ",StringSplitOptions.RemoveEmptyEntries)
                        .Select(double.Parse).ToArray();
                    
                    
                    for (int i = 0; i < NUmbers.Length; i++)
                    {
                        
                        Console.WriteLine($"{NUmbers[i]} => {Math.Round(NUmbers[i], MidpointRounding.AwayFromZero)}");
                    }



                    break;
                case "4":
                    string[] letters = Console.ReadLine()
                        .Split(separator: " ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                    Array.Reverse(letters);
                    for (int i = 0; i < letters.Length; i++)
                    {
                        Console.Write(letters[i] + " ");
                    }



                    break;
                case "5":
                    int[] NUms = Console.ReadLine()
                        .Split(separator: " ", StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse).ToArray();
                    int sum = 0;
                    for (int i = 0; i < NUms.Length; i++)
                    {
                        if (NUms[i] % 2 == 0)
                        {
                            sum += NUms[i];
                        }
                    }
                    Console.WriteLine(sum);
                    break;
                case "6":
                    int[] Nums = Console.ReadLine()
                        .Split(separator: " ", StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse).ToArray();
                    int sumEven = 0;
                    int sumOdd = 0;
                    foreach(int number in Nums)
                    {
                        if (number % 2 == 0)
                        {
                            sumEven += number;
                        }
                        else
                        {
                            sumOdd += number;
                        }
                    }
                    Console.WriteLine(sumEven - sumOdd);



                    break;
                case "7":
                    int[] nums = Console.ReadLine()
                        .Split()
                        .Select(int.Parse)
                        .ToArray();

                    while (nums.Length > 1)
                    {
                        int[] condensed = new int[nums.Length - 1];

                        for (int i = 0; i < nums.Length - 1; i++)
                        {
                            condensed[i] = nums[i] + nums[i + 1];
                        }

                        nums = condensed;
                    }

                    Console.WriteLine(nums[0]);

                    break;
            }
        }
    }
}