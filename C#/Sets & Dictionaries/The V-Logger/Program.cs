using System;
using System.Collections.Generic;
using System.Linq;

class VLogger
{
    static void Main()
    {
        Dictionary<string, Vlogger> vloggers = new Dictionary<string, Vlogger>();

        while (true)
        {
            string inputLine = Console.ReadLine();
            if (inputLine == "Statistics")
                break;

            string[] input = inputLine.Split();
            string vloggerName = input[0];

            if (inputLine.Contains("joined"))
            {
                if (!vloggers.ContainsKey(vloggerName))
                {
                    vloggers[vloggerName] = new Vlogger();
                }
            }
            else if (inputLine.Contains("followed"))
            {
                string followedVlogger = input[2];

                if (vloggers.ContainsKey(vloggerName) && vloggers.ContainsKey(followedVlogger) && vloggerName != followedVlogger)
                {
                    vloggers[vloggerName].Following.Add(followedVlogger);
                    vloggers[followedVlogger].Followers.Add(vloggerName);
                }
            }
        }

        Console.WriteLine($"The V-Logger has a total of {vloggers.Count} vloggers in its logs.");

        int count = 1;

        foreach (var vlogger in vloggers.OrderByDescending(v => v.Value.Followers.Count).ThenBy(v => v.Value.Following.Count))
        {
            Console.Write($"{count}. {vlogger.Key} : {vlogger.Value.Followers.Count} followers, {vlogger.Value.Following.Count} following");

            if (count == 1)
            {
                foreach (var follower in vlogger.Value.Followers.OrderBy(f => f))
                {
                    
                    Console.WriteLine($"* {follower}");
                }
            }

            Console.WriteLine();
            count++;
        }
    }
}

class Vlogger
{
    public HashSet<string> Followers { get; set; }
    public HashSet<string> Following { get; set; }

    public Vlogger()
    {
        Followers = new HashSet<string>();
        Following = new HashSet<string>();
    }
}
