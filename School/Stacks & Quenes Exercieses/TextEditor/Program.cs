namespace TextEditor
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<string> operations = new List<string>();

            for (int i = 0; i < n; i++)
            {
                operations.Add(Console.ReadLine());
            }

            SimpleTextEditor(operations);
        }

        static void SimpleTextEditor(List<string> operations)
        {
            Stack<string> textStack = new Stack<string>();
            string text = "";

            foreach (string op in operations)
            {
                string[] tokens = op.Split();
                string command = tokens[0];

                if (command == "1")
                {
                    textStack.Push(text);
                    text += tokens[1];
                }
                else if (command == "2")
                {
                    textStack.Push(text);
                    int count = int.Parse(tokens[1]);
                    text = text.Substring(0, text.Length - count);
                }
                else if (command == "3")
                {
                    int index = int.Parse(tokens[1]) - 1;
                    Console.WriteLine(text[index]);
                }
                else if (command == "4")
                {
                    text = textStack.Pop();
                }
            }
        }
    }
}