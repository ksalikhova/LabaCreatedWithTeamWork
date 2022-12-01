using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabaCreatedWithTeamWork
{
    interface IAddPlayer
    {
       void AddPlayer (string nick);
    }

    public class AddingPlayer: IAddPlayer
    {
        public void AddPlayer(string nick)
        {
            int raiting = 0;
            //получаем ник игрока, ищем его в базе методом базы, если есть, подтягиваем рейтинг, если нетт, рейтинг 0
            Player player = new Player(nick, raiting);
        }
    }


    interface IAnalyzeMove
    { 
        void AnalyzeMove();
    }

    public class AnalyzingMove: IAnalyzeMove
    {
        public bool IsPlayerMove { get;}
        public bool IsOpponentMove { get; }

        public AnalyzingMove()
        {
            IsPlayerMove = true;
            IsOpponentMove = false;
        }



    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
