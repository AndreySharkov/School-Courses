using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arena
{
    internal interface IArena
    {
        int GladiatorCount { get; }

        string AddGladiator(Gladiator gladiator);
        bool RemoveGladiator(string name);
        Gladiator GetStrongestGladiator();
        string Battle(string firstName, string secondName);
        string ArenaInfo();
    }

}
