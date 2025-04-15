using Interfaces;

public class Program
{
    public static void Main()
    {
        IDrawable circle = new Circle(5);
        IDrawable rectangle = new Rectangle(10, 5);

        Console.WriteLine("Circle:");
        circle.Draw();

        Console.WriteLine("\nRectangle:");
        rectangle.Draw();
    }
}
