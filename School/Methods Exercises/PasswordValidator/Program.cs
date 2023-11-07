namespace PasswordValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            ValidatePassword(password);
        }
        static void ValidatePassword(string password)
        {
            string notAllowedSymboolls = "!@#$%^&**()_+-=[{}|]:;?.<>$";
            string Nums = "1234567890";
            bool badPass = false;
            if (password.Length >= 6 &&  password.Length <= 10) { }
            else
            {
                badPass = true;
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            int AcceptPass = 0;
            foreach (char c in password)
            {
                if (notAllowedSymboolls.Contains(c))
                {
                    AcceptPass++;
                }

            }

            if (AcceptPass == 0) { }
            else
            {
                badPass = true;
                Console.WriteLine("Password must consist only of letters and digits");
            }

            int numCount = 0;
            foreach (char c in password)
            {
                if (Nums.Contains(c))
                {
                    numCount++;
                }

            }
            if (numCount >= 2) { }
            else
            {
                badPass = true;
                Console.WriteLine("Password must have at least 2 digits");
            }

            

            if (badPass) { return; }
            Console.WriteLine("Password is valid");
        }
    }
}