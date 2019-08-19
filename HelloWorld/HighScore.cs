//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace HighScore
//{
//    class Program
//    {
//        static int highScore = 300;
//        static string highScorePlayer = "Jane";

//        static void Main(string[] args)
//        {
//            CheckHighScore(250, "Maria");
//            CheckHighScore(315, "Angela");
//            CheckHighScore(350, "Jane");

//            Console.Read();
//        }

//        public static void CheckHighScore(int score, string playerName)
//        {
//            if(score > highScore)
//            {
//                highScore = score;
//                highScorePlayer = playerName;

//                Console.WriteLine("New high score is {0}; held by player {1}", score, playerName);
//            } else
//            {
//                Console.WriteLine("Old high score is not broken. It is still {0}, held by {1}", highScore, highScorePlayer);
//            }
//        }
//    }
//}