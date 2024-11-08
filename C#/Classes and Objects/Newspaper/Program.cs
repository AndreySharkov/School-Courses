using Newspaper;

public class Program
{
    public static void Main()
    {
        string[] initialInput = Console.ReadLine().Split(", ");
        string title = initialInput[0];
        string text = initialInput[1];
        string writer = initialInput[2];

        News newsItem = new News(title, text, writer);
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string commandInput = Console.ReadLine();
            string[] commandParts = commandInput.Split(": ", 2);

            string command = commandParts[0];
            string argument = commandParts[1];

            switch (command)
            {
                case "Edit":
                    newsItem.Edit(argument);
                    break;
                case "ChangeWriter":
                    newsItem.ChangeWriter(argument);
                    break;
                case "Rename":
                    newsItem.Rename(argument);
                    break;
            }
        }
        Console.WriteLine(newsItem);
    }
}