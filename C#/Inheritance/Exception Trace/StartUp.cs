using System;

namespace ExceptionTrace
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            try
            {
                MyFileReader reader = new MyFileReader("numbers.txt");
                reader.ReadAndSum();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
