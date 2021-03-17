using NUnit.Framework;
using AlgoProject.Problems;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoProject.Tests.Problems
{
    [TestFixture]
    public class TournamentWinnerTests
    {
        [Test]
        public void CalcWinner_PythonWonMostRounds_TeamWithMostPointsWins()
        {
            List<List<string>> competitions = new List<List<string>>();
            List<int> results = new List<int> { 0, 0, 1 };
            competitions.Add(new List<string> { "HTML", "C#" });
            competitions.Add(new List<string> { "C#", "Python" });
            competitions.Add(new List<string> { "Python", "HTML" });
            string expected = "python";

            string answer = TournamentWinner.CalcWinner(competitions, results);

            Assert.That(answer, Is.EqualTo(expected).IgnoreCase);
        }
    }
}
