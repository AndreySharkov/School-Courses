using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        LinkedList<string> linkedList = new LinkedList<string>();

        // Read input strings
        string firstString = Console.ReadLine();
        string secondString = Console.ReadLine();
        string thirdString = Console.ReadLine();
        string fourthString = Console.ReadLine();

        // 1. First string becomes first in the sequence
        LinkedListNode<string> firstNode = linkedList.AddFirst(firstString);

        // 2. Second string becomes last in the sequence
        LinkedListNode<string> lastNode = linkedList.AddLast(secondString);

        // 3. Third string should be right after the first one
        linkedList.AddAfter(firstNode, thirdString);

        // 4. Fourth string should be right before the last one
        linkedList.AddBefore(lastNode, fourthString);

        // Print all strings in the right order, separated by ", "
        Console.WriteLine(string.Join(", ", linkedList));
    }
}
