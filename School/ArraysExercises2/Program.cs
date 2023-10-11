namespace ArraysExercises2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int .Parse(Console.ReadLine());
            switch (input)
            {
                case 1:

                    int num = int.Parse(Console.ReadLine());
                    int[] array1 = new int[num];
                    int sum = 0;
                    for (int i = 0; i < array1.Length; i++)
                    {
                        array1[i] = int.Parse(Console.ReadLine());
                        sum += array1[i];
                    }
                    
                    Console.WriteLine(string.Join(separator:" ", array1));
                    Console.WriteLine(sum);

                    break;
                case 2:
                    int numb = int.Parse(Console.ReadLine());
                    
                    int[] firstElem = new int[numb];
                    int[] SecondElem = new int[numb];

                    for (int i = 1; i <= numb; i++)
                    {
                        int[] array2 = Console.ReadLine().Split(separator:" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                        if (i % 2 == 0)
                        {
                            SecondElem[i - 1] = array2[0];
                            firstElem[i - 1] = array2[1];
                            
                        }
                        else
                        {
                            SecondElem[i - 1] = array2[1];
                            firstElem[i - 1] = array2[0];

                        }
                    }
                    Console.WriteLine(string.Join(separator: " ", firstElem));
                    Console.WriteLine(string.Join(separator: " ", SecondElem));

                    break;
                case 3:
                    int[] array3 = Console.ReadLine()
                        .Split(separator: " ", StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse).ToArray();
                    int Number = int.Parse(Console.ReadLine());
                    for (int i = 0; i < Number;i++)
                    {
                        for (int j = array3.Length - 1 ; j >= 0; j--)
                        {
                            int temp = array3[array3.Length -1];
                            array3[array3.Length -1] = array3[j];
                            array3[j] = temp;
                        }
                    }
                    Console.WriteLine(string.Join(separator: " ", array3));
                    break; 
                case 4:
                    int[] array4 = Console.ReadLine()
                        .Split(separator: " ", StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse).ToArray();
                    int biigestNum = 0;
                    int biigestNumLenght = 0;
                    foreach (int i in array4)
                    {
                        if(i > biigestNum)
                        {
                            biigestNum = i;
                            biigestNumLenght++;
                        }
                    }
                    for (int i = biigestNumLenght; i <= array4.Length - biigestNumLenght; i++)
                    {
                        
                        Console.Write(string.Join(separator: " ", array4));
                    }

                    break;
            }
        }
    }
}