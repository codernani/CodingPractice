using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public  class Winner
    {
        public string TournamentWinner(List<List<string>> competitions, List<int> results)
        {
            // Home team, Away team, Winning team.
            string currentTeam = "";
            for (int i = 0; i < competitions.Count; i++)
            {
                

                Dictionary<string,int> scores = new Dictionary<string,int>();
                scores[currentTeam] = 0;

                List<string> competition = competitions[i];
                int result = results[i];

                string homeTeam = competition[0];
                string awayTeam = competition[1];

                string winningteam = (result == 1)? homeTeam : awayTeam;

                updateScores(winningteam, 3, scores);

                if (scores[winningteam] > scores[currentTeam])
                {
                    currentTeam = winningteam;
                }
            }

            return currentTeam;
        }

        public void updateScores(string team, int points, Dictionary<string,int> scores)
        {
            if (!scores.ContainsKey(team))
            {
                scores[team] = 0;
            }
            scores[team] = scores[team] + points;         
          


        }
    }
}
