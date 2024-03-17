namespace Multiply_Big_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string num1 = Console.ReadLine();
            int num2 = int.Parse(Console.ReadLine());

            int carry = 0;
            string result = "";

            for (int i = num1.Length - 1; i >= 0; i--)
            {
                int digit = num1[i] - '0';
                int product = digit * num2 + carry;
                carry = product / 10;
                result = (product % 10) + result;
            }

            if (carry > 0)
                result = carry + result;

            result = result.TrimStart('0');
            Console.WriteLine(result);
        }
    }
}