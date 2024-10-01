using System.Text;

namespace SecretMessage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string secretMessage = Console.ReadLine();
            while(true)
            {
                string commandStr = Console.ReadLine();
                if(commandStr == "Read")
                {
                    break;
                }
                string[] command = commandStr.Split("<->").ToArray();
                switch(command[0].ToLower())
                {
                    case "space":
                        secretMessage = secretMessage.Insert(int.Parse(command[1]), " ").ToString();
                        Console.WriteLine(secretMessage);

                        break;
                    case "backward":
                        int index = secretMessage.IndexOf(command[1]);
                        if (index != -1)
                        {
                            string substring = secretMessage.Substring(index, command[1].Length);
                            string reversedSubstring = new string(substring.Reverse().ToArray());
                            secretMessage = secretMessage.Remove(index, command[1].Length);
                            secretMessage += reversedSubstring;
                            
                            Console.WriteLine(secretMessage);
                        }
                        else
                        {
                            Console.WriteLine("error");
                        }
                        break;
                    case "replaceall":
                        secretMessage = secretMessage.Replace(command[1], command[2]);
                        Console.WriteLine(secretMessage);
                        break;
                }
                
            }
            Console.WriteLine($"You have a secret text message: {secretMessage}");
        }
    }
}
