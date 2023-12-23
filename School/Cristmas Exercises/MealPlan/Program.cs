using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] meals = Console.ReadLine().Split();
        int[] dailyCalories = Console.ReadLine().Split().Select(int.Parse).ToArray();

        Queue<string> mealsQueue = new Queue<string>(meals);
        Queue<int> caloriesQueue = new Queue<int>(dailyCalories);

        int mealsCount = 0;

        while (mealsQueue.Count > 0 && caloriesQueue.Count > 0)
        {
            int currentCalories = caloriesQueue.Peek();
            string currentMeal = mealsQueue.Peek();

            if (currentCalories >= GetCalories(currentMeal))
            {
                mealsQueue.Dequeue();
                caloriesQueue.Dequeue();
                mealsCount++;
            }
            else
            {
                caloriesQueue.Dequeue();
                caloriesQueue.Enqueue(currentCalories - GetCalories(currentMeal));
                mealsQueue.Enqueue(currentMeal);
            }
        }

        if (mealsQueue.Count == 0)
        {
            Console.WriteLine($"John had {mealsCount} meals.");
            Console.WriteLine($"For the next few days, he can eat {string.Join(", ", caloriesQueue)} calories.");
        }
        else
        {
            Console.WriteLine($"John ate enough, he had {mealsCount} meals.");
            Console.WriteLine($"Meals left: {string.Join(", ", mealsQueue)}.");
        }
    }

    static int GetCalories(string meal)
    {
        switch (meal)
        {
            case "salad": return 350;
            case "soup": return 490;
            case "pasta": return 680;
            case "steak": return 790;
            default: return 0;
        }
    }
}
