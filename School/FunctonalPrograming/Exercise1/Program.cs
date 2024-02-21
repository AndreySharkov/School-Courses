namespace Exercise1
{
    internal class Program
    {
        public delegate int Multiplier(int x, int y);

        static void Main(string[] args)
        {
            Multiplier calc = (x, y) => x * y;
            Jerry jery = new Jerry();
            jery.age = 1000;
            jery.name = "JerryNigger";
            Func<int, string> func = n => n.ToString();
            string jeryageString = func(jery.age);
            Action<string> print = jerya => Console.WriteLine(jerya);
            print(jeryageString); //1000

        }
        
    }
    public class Jerry
    {
        public int age = 0;
        public string name = "";
    }
}