using System;
using System.IO;

namespace ExceptionTrace
{
    public class MyFileReader
    {
        private string path;

        public string Path
        {
            get => path;
            set => path = value;
        }

        public MyFileReader(string path)
        {
            this.Path = path;
        }

        public void ReadAndSum()
        {
            if (string.IsNullOrEmpty(this.Path))
            {
                throw new ArgumentException("Invalid Path or File Name.");
            }

            string[] lines = File.ReadAllLines(this.Path);
            int sum = 0;
            for (int i = 0; i < lines.Length; i++)
            {
                try
                {
                    sum += int.Parse(lines[i]);
                }
                catch (FormatException)
                {
                    throw new ArgumentException($"Error: On the line {i + 1} of the file the value was not in the correct format.");
                }
            }
            Console.WriteLine($"The sum of all correct numbers is: {sum}");
        }
    }
}
