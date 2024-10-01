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
            int check = 0;
            if (HasRequiredPassWordSize(password)) check++;

            if (HasRequiredAlphanumeriCharacters(password)) check++;

            if (HasEnoughtDigitAccept(password))check++;

            

            if (check == 3)
            {
                Console.WriteLine("Password is valid");
            }

        }
        static bool HasRequiredPassWordSize(string password)
        {
            
            if (password.Length >= 6 && password.Length <= 10)
            {
                return true;
            }
            else
            {
                
                Console.WriteLine("Password must be between 6 and 10 characters");
                return false;
            }
        }
        static bool HasRequiredAlphanumeriCharacters(string password)
        {
            string notAllowedSymboolls = "!@#$%^&**()_+-=[{}|]:;?.<>$";
            foreach (char c in password)
            {
                if (notAllowedSymboolls.Contains(c))
                {
                    
                    Console.WriteLine("Password must consist only of letters and digits");
                    return false;
                }

            }
            return true;
        }
        static bool HasEnoughtDigitAccept(string password)
        {
            string Nums = "1234567890";
            int numCount = 0;
            foreach (char c in password)
            {
                if (Nums.Contains(c))
                {
                    numCount++;
                }

            }
            if (numCount >= 2) return true;
            else
            {
                Console.WriteLine("Password must have at least 2 digits");
                return false;
                
            }
        }
    }
}