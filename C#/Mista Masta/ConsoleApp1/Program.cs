using System;
using System.Collections.Generic;
using System.Linq;

namespace ConnectedComponents
{
    class Program
    {
        static List<int>[] graph;
        static bool[] visited;

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            graph = new List<int>[n];
            visited = new bool[n];

            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                
                if (string.IsNullOrWhiteSpace(line))
                {
                    graph[i] = new List<int>();
                }
                else
                {
                    graph[i] = line.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                   .Select(int.Parse)
                                   .ToList();
                }
            }

            for (int i = 0; i < n; i++)
            {
                if (!visited[i])
                {
                    List<int> component = new List<int>();
                    DFS(i, component);
                    Console.WriteLine($"Connected component: {string.Join(" ", component)}");
                }
            }
        }
        static void DFS(int node, List<int> component)
        {
            if (!visited[node])
            {
                visited[node] = true;
                foreach (int child in graph[node])
                {
                    DFS(child, component);
                }
                component.Add(node);
            }
        }
    }
}