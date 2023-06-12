using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T5CS
{
    abstract class TeamSport : ISport
    {
        public abstract int NumberOfPlayers { get; set; }
        public abstract int NumberOfTeams { get; set; }
        public abstract string[] TeamList { get; set; }
        public abstract int FieldSize { get; set; }
        public abstract string SportName { get; set; }

        public abstract int[] Score { get; set; }
        public TeamSport() { }

        public abstract string GetWinner();
        public abstract void AddScore(int TeamId);

    }
}