using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGame
{
    public class GameBoard
    {
        public int GameIndex { get; set; }
        public DifficultyLevel GameLevel { get; set; }
        public int[,] DisplayBoard { get; set; }
        public int[,] PlayerBoard { get; set; }
        public int[,] AnswerBoard { get; set; }
        public GameStatus GameStatus { get; set; }
        public TimeSpan TimeSpan { get; set; }

        public TimeSpan BestTimeSpan { get; set; }

        public int GridLength { get; set; }
        public bool HasCheated { get; set; }
    }

    /// <summary>
    /// GameStatus.
    /// </summary>
    public enum GameStatus
    {
        UnSolved = 0, InProgress = 1, Completed = 2
    }

    /// <summary>
    /// DifficultyLevel.
    /// </summary>
    public enum DifficultyLevel
    {
        none =0,easy =1,medium=2,hard=3 
    }
}
