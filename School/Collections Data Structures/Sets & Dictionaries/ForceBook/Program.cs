namespace ForceBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();
            string inputString;
            while((inputString = Console.ReadLine()) != "Lumpawaroo")
            {
                string[] input = inputString.Split();
                if (input[1] == "|")
                {
                    if (!dictionary.ContainsKey(input[0]))
                    {
                        dictionary.Add(input[0], new List<string>());
                        dictionary[input[0]].Add(input[2]);
                    }
                    else
                    {
                        dictionary[input[0]].Add(input[2]);
                    }
                }
                else
                {
                    Console.WriteLine($"{input[2]} joins the {input[0]} side!");
                    foreach (var key in dictionary.Keys)
                    {
                        dictionary[key].Remove(input[2]);
                    }
                    if (!dictionary.ContainsKey(input[0]))
                    {
                        dictionary.Add(input[0], new List<string>());
                        dictionary[input[0]].Add(input[2]);
                    }
                    else
                    {
                        dictionary[input[0]].Add(input[2]);
                    }
                }
                
            }

        }
    }
}