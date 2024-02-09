namespace Count_Same_Values_in_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine().Split().Select(double.Parse).ToArray();
            Dictionary<double, int> keyValuePairs = new Dictionary<double, int>();
            foreach (double num in input)
            {
                if(!keyValuePairs.ContainsKey(num))
                {
                    keyValuePairs.Add(num, 0);
                    keyValuePairs[num]++;
                }
                else
                {
                    keyValuePairs[num]++;
                }
            }
            foreach(var key in keyValuePairs.Keys)
            {
                Console.WriteLine($"{key} - {keyValuePairs[key]} times");
            }
        }
    }
}