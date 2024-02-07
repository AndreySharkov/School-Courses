namespace GreaterThanTwoValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            GetMax(type, x, y);
        }
        static void GetMax(string type, string x, string y)
        {
            switch (type)
            {
                case "int":
                    if (int.Parse(x) < int.Parse(y))
                    {
                        Console.WriteLine(y);
                    }
                    else
                    {
                        Console.WriteLine(x);
                    }
                break;
                case "char":
                    if (char.Parse(x) < char.Parse(y))
                    {
                        Console.WriteLine(y);
                    }
                    else
                    {
                        Console.WriteLine(x);
                    }
                    break;
                case "string":
                    int dX = 0;
                    int dY = 0;
                    if (x.Length == y.Length)
                    {
                        for (int i = 0; i < x.Length; i++)
                        {
                            if (x[i] < y[i])
                            {
                                dY++;
                            }
                            else
                            {
                                dX++;
                            }

                        }
                    }
                    else if (x.Length < y.Length)
                    {
                        dY++;
                    }
                    else
                    {
                        dX++;
                    }
                    
                    if (dY > dX)
                    {
                        Console.WriteLine(y);
                    }
                    else 
                    {
                        Console.WriteLine(y); 
                    }
                    
                    break;
            }
        }
    }
}