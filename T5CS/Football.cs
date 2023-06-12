using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T5CS
{
    internal class Football : TeamSport
    {
        private string DescriptionOfTeam1 { get; set; }
        private string DescriptionOfTeam2 { get; set; }
        public override int NumberOfTeams { get; set; }
        public override string[] TeamList { get; set; }
        public override int NumberOfPlayers { get; set; }
        public override int FieldSize { get; set; }
        public override string SportName { get; set; }
        public override int[] Score { get; set; }

        //private int NumberOfPlayers;
        //private int NumberOfTeams;
        //private string[] TeamList;
        //private int FieldSize;
        //private string SportName;
        //private int[] Score;

        public Football() : base()
        {
            NumberOfTeams = 2;
            SportName = "Football";
            Score = new int[] { 0, 0 };
            TeamList = new string[2];
        }

        public Football(int numberOfPlayers, int fieldSize, string nameOfTeam1, string nameOfTeam2, string descriptionOfTeam1, string descriptionOfTeam2) : base()
        {
            NumberOfTeams = 2;
            SportName = "Football";
            Score = new int[] { 0, 0 };
            TeamList = new string[2];
            NumberOfPlayers = numberOfPlayers;
            FieldSize = fieldSize;
            TeamList = new string[] { nameOfTeam1, nameOfTeam2 };
            DescriptionOfTeam1 = descriptionOfTeam1;
            DescriptionOfTeam2 = descriptionOfTeam2;

        }
        public override string GetWinner()
        {
            if (Score[0] > Score[1]) {
                return TeamList[0];
            }
            else if (Score[1] > Score[0]) {
                return TeamList[1];
            }
            else
            {
                return "Draw";
            }

        }

        public override void AddScore(int TeamId)
        {
            Score[TeamId] += 1; 
        }
        public string toString()
        {
            return string.Format("Команда: {0} = {1} очков || Команда: {2} = {3} очков", TeamList[0], Score[0], TeamList[1], Score[1]);
        }
    }

}