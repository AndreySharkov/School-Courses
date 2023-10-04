namespace JeriMoment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            switch(input)
            {
                case 1:
                    int first = int.Parse(Console.ReadLine());


                    int second = int.Parse(Console.ReadLine());


                    int third = int.Parse(Console.ReadLine());


                    int fourth = int.Parse(Console.ReadLine());


                    double sumResult = first + second;
                    double divisionResult = (sumResult / third);
                    double multiplicationResult = divisionResult * fourth;


                    Console.WriteLine(multiplicationResult);
                    break;

                case 2:
                    int Number = int.Parse(Console.ReadLine());
                    double NumSum = 0;
                    while(Number > 0)
                    {
                        Number = Number / 10;
                        
                        NumSum += Number % 10;
                    }
                    Console.WriteLine(NumSum);
                    break;
                case 3:

                    break;

                case 4:

                    break;
                case 5:

                    break;
                case 6:

                    break;
                case 7:

                    break;
                case 8:

                    break;
                case 9:

                    break;
                case 10:

                    break;

                case 11:

                    break;
                    
            }
            
        }
    }
}