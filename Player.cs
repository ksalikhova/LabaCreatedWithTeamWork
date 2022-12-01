using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LabaCreatedWithTeamWork
{
     public class Player
    {
        public string NickName { get; init; }
        public List<Card> CardsInHands { get; init; } // List of 8 cards or more
        public int PointsPerGame { get; set; }
        public int GlobalRating { get; set; }

        private int health;

        public int GetHealth()
        {
            return health;
        }

        public Player (string nickName, List<Card> cards)
        {
            NickName = nickName;
            CardsInHands = cards;
            PointsPerGame = 0;
            GlobalRating = 0;
            health = 30; // Hard Code
        }

        public Card MakeMove() // TODO: change logic like -> choosing card of list cards not through random
        {
            Card card = ChooseCardFromHand(CardsInHands); // TODO: write this method, it interacts with the user through users interface
            //Random random = new Random();
            //int index = random.Next(CardsInHands.Count);
            CardsInHands.Remove(card);
            return card; 
        }
/*        public void RemoveCard (Card card) // TODO : replace this method on the different
        {
            CardsInHands.Remove(card);
        }
*/
        public void TakeTheCardInHands(Card card) 
        {
          CardsInHands.Add(card);
        }
        public void GetDamage(int damage)
        {
            health -=damage;
        }
        //пробный коммит
        // пробный коммит номер 2
    }
}
