namespace EIGNValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var validator = new EGNValidator();

            string testEGN = "0847038794";
            Console.WriteLine($"EGN {testEGN} is valid: {validator.Validate(testEGN)}");

            var generated = validator.Generate(new DateTime(2008, 7, 3), "София – град", false);
            foreach (var egn in generated)
            {
                Console.WriteLine(egn);
            }
        }
    }
}

