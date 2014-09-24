using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipBL
{
    class Program
    {
        static void Main(string[] args)
        {
            Grid grid = new Grid();
        }
        static void AddHighScore(int PlayerScore)
        {
            Console.WriteLine("Your Name");
            string playerName = Console.ReadLine();
            NORTHWNDEntities db = new NORTHWNDEntities();

            //create a new highscore
            HighScore newHighScore = new HighScore();
            newHighScore.Date = DateTime.Now;
            newHighScore.Game = "BattleShip";
            newHighScore.Name = playerName;
            newHighScore.Score = PlayerScore;

            //add it to the data base

            db.HighScores.Add(newHighScore);

            //save changes 
            db.SaveChanges();


        }

        static void DisplayHighScore()
        {
            Console.WriteLine("Display BattleShip High Score");
            Console.WriteLine("--------------");

            NORTHWNDEntities db = new NORTHWNDEntities();
            List<HighScore> highScoreList = db.HighScores.Where(x => x.Game == "Battleship")
                .OrderByDescending(x => x.Score).Take(10).ToList();

            foreach (HighScore highScore in highScoreList)
            {
                Console.WriteLine("{0}. {1}- {2} on {3}",
                highScoreList.IndexOf(highScore) + 1,
                highScore.Name,
                highScore.Score,
                highScore.Date.Value.ToShortDateString());

            }
        }
    }
}
