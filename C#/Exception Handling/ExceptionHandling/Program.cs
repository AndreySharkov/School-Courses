namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            throw new PrinterException("Printer is out of paper!");
        }
        public class PrinterException : Exception
        {
            public PrinterException(string msg)
            : base(msg) { }

        }
    }
}
//inavalid parameter to method
//ArgumentException,ArgumentNullException,ArgumentOutOfRangeException;
//when a operation is not suported 
// ExceptionNotSUpported
//