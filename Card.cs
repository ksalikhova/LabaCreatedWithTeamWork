using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabaCreatedWithTeamWork
{
    public class Card : ICard, ICloneable
    {

        public string Name
        {
            get { return Name; }
            init { this.Name = value; }
        }

        public int Damage
        {
            get { return Damage; }
            init { this.Damage = value; }
        }
        public int CardHealth
        {
            get { return CardHealth; }
            init { this.CardHealth = value; }
        }

        public int CardHeal 
        {
            get { return CardHeal; }
            init { this.CardHeal = value; }
        }

        public Card(string name, int damage, int cardHealth, int cardHeal)
        {
            Name = name;
            Damage = damage;
            CardHealth = cardHealth;
            CardHeal = cardHeal;
        }

        public Card() 
        {
            Name = "";
            Damage = 0;
            CardHealth = 0;
            CardHeal = 0;
        }

        public object Clone()
        {
            var cardClone = new Card();
            return cardClone;
        }
    }
}
