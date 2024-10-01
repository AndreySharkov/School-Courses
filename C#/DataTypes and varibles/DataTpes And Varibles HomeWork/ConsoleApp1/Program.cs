using System;

namespace JeriMoment
{
    internal class Program
    {
        static void Main(string[] args)
        {
#pragma warning disable CS8604 // Possible null reference argument.
            int input = int.Parse(Console.ReadLine());

            switch (input)
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

                    while (input1v1 <= input1v2)
                    {
                        char Char = Convert.ToChar(input1v1);
                        Console.Write(Char + " ");
                        input1v1++;
                    }
                    break;
                case 6:
                    int input6_1 = int.Parse(Console.ReadLine());
                    for (int i = 0; i < input6_1; i++)
                    {
                        for (int j = 0; j < input6_1; j++)
                        {
                            for (int k = 0; k < input6_1; k++)
                            {
                                char firstChar = (char)('a' + i);
                                char secondChar = (char)('a' + j);
                                char thirdChar = (char)('a' + k);
                                Console.WriteLine(firstChar + "" + secondChar + "" + thirdChar);
                            }
                        }
                    }
                    break;
                case 7:
                    int numberOfLines = int.Parse(Console.ReadLine());
                    int WaterInTank = 0;
                    int WaterQuantiti = 0;
                    for (int i = 0; i < numberOfLines; i++)
                    {
                        WaterQuantiti = int.Parse(Console.ReadLine());
                        if (WaterInTank + WaterQuantiti > 255)
                        {
                            Console.WriteLine("Insufficient capacity!");

                        }
                        else
                        {
                            WaterInTank += WaterQuantiti;
                        }
                    }
                    Console.WriteLine(WaterInTank);


                    break;
                case 8:
                    int Input9 = int.Parse(Console.ReadLine());
                    string biggestKegModel = "";
                    double maxVolume = -1;

                    for (int i = 0; i < Input9; i++)
                    {
                        string model = Console.ReadLine();
                        double radius = double.Parse(Console.ReadLine());
                        int height = int.Parse(Console.ReadLine());

                        double volume = Math.PI * Math.Pow(radius, 2) * height;

                        if (volume > maxVolume)
                        {
                            maxVolume = volume;
                            biggestKegModel = model;
                        }
                    }

                    Console.WriteLine(biggestKegModel);
                    break;
            }
                    
            }
            
        }
    }
}