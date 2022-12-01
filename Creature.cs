using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    internal class Creature : Card
    {
        public Creature(string name, int damage, int cardHealth) : base(name, damage, cardHealth)
        {
            this.Name = name;
            this.Damage = damage;
            this.CardHealth = cardHealth;
        }
    }
}
