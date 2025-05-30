using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arena
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Arena : IArena
    {
        private List<Gladiator> roster;

        public string City { get; set; }
        public int Capacity { get; set; }

        public Arena(string city, int capacity)
        {
            City = city;
            Capacity = capacity;
            roster = new List<Gladiator>();
        }

        public int GladiatorCount => roster.Count;

        public string AddGladiator(Gladiator gladiator)
        {
            if (roster.Count >= Capacity)
            {
                return "The arena is full";
            }

            if (roster.Any(g => g.Name == gladiator.Name))
            {
                return $"{gladiator.Name} is already enlisted";
            }

            roster.Add(gladiator);
            return $"{gladiator.Name} successfully enlisted in the arena";
        }

        public bool RemoveGladiator(string name)
        {
            var gladiator = roster.FirstOrDefault(g => g.Name == name);
            if (gladiator != null)
            {
                roster.Remove(gladiator);
                return true;
            }
            return false;
        }

        public Gladiator GetStrongestGladiator()
        {
            return roster.OrderByDescending(g => g.Strength).FirstOrDefault();
        }

        public string Battle(string firstName, string secondName)
        {
            Gladiator first = roster.First(g => g.Name == firstName);
            Gladiator second = roster.First(g => g.Name == secondName);

            if (first.Strength > second.Strength)
            {
                second.Health -= first.Strength;
                string result = $"The winner is {first.Name}.";
                if (second.Health <= 0)
                {
                    roster.Remove(second);
                    result += $"{second.Name} died in the arena.";
                }
                return result;
            }
            else if (second.Strength > first.Strength)
            {
                first.Health -= second.Strength;
                string result = $"The winner is {second.Name}.";
                if (first.Health <= 0)
                {
                    roster.Remove(first);
                    result += $"{first.Name} died in the arena.";
                }
                return result;
            }
            else
            {
                return "There is no winner.";
            }
        }

        public string ArenaInfo()
        {
            var info = $"Warriors enlisted in the Grand Arena of {City}:";
            foreach (var gladiator in roster)
            {
                info += Environment.NewLine + gladiator.ToString();
            }
            return info;
        }
    }

}
