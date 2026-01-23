using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        // Print top hashes
        PrintHashes(n, 0);

        // Print bottom stars
        PrintStars(1, n);
    }

    // Recursive method for top part (#)
    static void PrintHashes(int remainingHashes, int spaces)
    {
        if (remainingHashes == 0)
            return;

        Console.Write(new string(' ', spaces));
        Console.WriteLine(new string('#', remainingHashes));

        PrintHashes(remainingHashes - 1, spaces + 1);
    }

    // Recursive method for bottom part (*)
    static void PrintStars(int currentStars, int n)
    {
        if (currentStars > n)
            return;

        Console.Write(new string(' ', n - currentStars));
        Console.WriteLine(new string('*', currentStars));

        PrintStars(currentStars + 1, n);
    }
}
