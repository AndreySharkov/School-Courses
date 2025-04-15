using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballTeam
{
    class Player
    {
        private string name;
        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;

        public Player(string name, int endurance, int sprint, int dribble, int passing, int shooting)
        {
            Name = name;
            Endurance = endurance;
            Sprint = sprint;
            Dribble = dribble;
            Passing = passing;
            Shooting = shooting;
        }

        public string Name
        {
            get => name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("A name should not be empty.");
                name = value;
            }
        }

        private int ValidateStat(int value, string statName)
        {
            if (value < 0 || value > 100)
                throw new ArgumentException($"{statName} should be between 0 and 100.");
            return value;
        }

        public int Endurance { get => endurance; private set => endurance = ValidateStat(value, "Endurance"); }
        public int Sprint { get => sprint; private set => sprint = ValidateStat(value, "Sprint"); }
        public int Dribble { get => dribble; private set => dribble = ValidateStat(value, "Dribble"); }
        public int Passing { get => passing; private set => passing = ValidateStat(value, "Passing"); }
        public int Shooting { get => shooting; private set => shooting = ValidateStat(value, "Shooting"); }

        public double SkillLevel => (Endurance + Sprint + Dribble + Passing + Shooting) / 5.0;
    }
}
