using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    internal class Card : ICard
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

        public Card(string name, int damage, int cardHealth)
        {
            Name = name;
            Damage = damage;
            CardHealth = cardHealth;
        }
    }
}
