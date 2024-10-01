
using System.ComponentModel.Design;
using System.Numerics;

namespace Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (true)
            {
                if (input == "END")
                {
                    break;
                }

                switch (input)
                {
                    case "1":
                        decimal num = decimal.Parse(Console.ReadLine());
                        decimal kilometer = num / 1000;
                        Console.WriteLine($"{kilometer:f2}");
                        break;

                    case "2":
                        decimal money = decimal.Parse(Console.ReadLine());
                        decimal pound = money * 1.31m;
                        Console.WriteLine($"{pound:f3}");
                        break;
                    case "3":
                        int n = int.Parse(Console.ReadLine());

                        decimal sum = 0;

                        for (int i = 0; i < n; i++)
                        {
                            decimal numb = decimal.Parse(Console.ReadLine());
                            sum += numb;

                        }
                        Console.WriteLine(sum);
                        break;
                    case "4":
                        double centuries = double.Parse(Console.ReadLine());
                        double years = centuries * 100;
                        double days = Math.Floor(years * 365.2422);
                        double hours = Math.Floor(days * 24);
                        double minutes = Math.Floor(hours * 60);

                        Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");

                        break;
                    case "5":
                        int loops = int.Parse(Console.ReadLine());
                        for (double i = 1; i <= loops; i++)
                        {
                            if (Math.Floor(i / 10) + i % 10 == 5 || Math.Floor(i / 10) + i % 10 == 7 || Math.Floor(i / 10) + i % 10 == 11)
                            {
                                Console.WriteLine($"{i} -> True");
                            }
                            else
                            {
                                Console.WriteLine($"{i} -> False");
                            }
                        }


                        break;
                    case "6":
                        char one = char.Parse(Console.ReadLine());
                        char two = char.Parse(Console.ReadLine());
                        char three = char.Parse(Console.ReadLine());

                        Console.Write($"{three}");
                        Console.Write($"{two}");
                        Console.Write($"{one}");

                        /*
                        var chars = new List<string>();
                        char one;
                        string jerr;
                        for (int i = 0; i <= 3; i++)
                        {
                            one = char.Parse(Console.ReadLine());
                            jerr = one.ToString() + " ";
                            chars.Add(jerr);
                        }
                        chars.Reverse();
                        for (int i = 0;i <= chars.Count;i++)
                        {
                            Console.Write(chars[i]);
                        }*/



                        break;

                    case "7":
                        string name = Console.ReadLine();
                        string surname = Console.ReadLine();
                        string sumthing = Console.ReadLine();
                        Console.WriteLine(name + sumthing + surname);



                        break;

                    case "8":
                        string TownName = Console.ReadLine();
                        int population = int.Parse(Console.ReadLine());
                        int area = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Town {TownName} has population of {population} and area {area} square km.");

                        break;

                    case "9":
                        char Uno = char.Parse(Console.ReadLine());
                        char Dos = char.Parse(Console.ReadLine());
                        char tress = char.Parse(Console.ReadLine());

                        Console.WriteLine(Uno.ToString() + Dos.ToString() + tress.ToString());

                        break;
                    case "10":
                        string inputiin = Console.ReadLine();
                        if (inputiin == inputiin.ToLower())
                        {
                            Console.WriteLine("lower-case");
                        }
                        else
                        {
                            Console.WriteLine("upper-case");
                        }

                        break;
                    case "12":
                        

                        break;


                }



            }
        }
    }
}