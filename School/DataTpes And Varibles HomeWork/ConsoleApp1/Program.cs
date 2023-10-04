namespace JeriMoment
{
    internal class Program
    {
        static void Main(string[] args)
        {
#pragma warning disable CS8604 // Possible null reference argument.
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

                    do
                    {

                        NumSum += Number % 10;
                        Number = Number / 10;

                    } while (Number > 0);
                    
                    Console.WriteLine(NumSum);
                    break;
                case 3:
                    double peoples = int.Parse(Console.ReadLine());
                    double capacity = int.Parse(Console.ReadLine());
                    Console.WriteLine(Math.Ceiling((peoples / capacity)));
                    break;

                case 4:
                    int n = int.Parse(Console.ReadLine());
                    int charCOde = 0;
                    for (int i = 0; i < n; i++)
                    {
                        char charcter = char.Parse(Console.ReadLine()); 
                        charCOde += charcter;
                    }
                    Console.WriteLine($"The sum equals: {charCOde}");

                    break;
                case 5:
                    int input1v1 = int.Parse(Console.ReadLine());
                    int input1v2 = int.Parse(Console.ReadLine());
                    
                    

                    for (int i = input1v1; i >= input1v2; i++)
                    {
                        
                        char RAAAAAAA = Convert.ToChar(i);
                        Console.Write(RAAAAAAA);
                        
                    }


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