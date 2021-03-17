using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoProject.Problems
{
    public static class TournamentWinner
    {
        public static string CalcWinner(List<List<string>> competitions, List<int> results)
        {
            Dictionary<string, int> comp = new Dictionary<string, int>();

            for (var i = 0; i < competitions.Count; i++)
            {
                if (results[i] == 1)
                {
                    if (comp.ContainsKey(competitions[i][0]))
                    {
                        comp[competitions[i][0]] += 3;
                    }
                    else
                    {
                        comp.Add(competitions[i][0], 3);
                    }
                }
                if (results[i] == 0)
                {
                    if (comp.ContainsKey(competitions[i][1]))
                    {
                        comp[competitions[i][1]] += 3;
                    }
                    else
                    {
                        comp.Add(competitions[i][1], 3);
                    }
                }
            }

            var listOfKeys = comp.Keys;
            int highScore = 0;
            string winner = "";

            foreach (var key in listOfKeys)
            {
                if (comp[key] > highScore)
                {
                    winner = key;
                    highScore = comp[key];
                }
            }

            return winner;  
        }
    }
}
