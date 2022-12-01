using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    internal class Spell : Card
    {
        public enum SpellType
        {
            Power,
            Protection
        }



        public Spell(SpellType type, string name, int damage, int cardHealth) : base(name, damage, cardHealth)
        {

            this.Name = name;
            if (type == SpellType.Power)
            {
                this.Damage = damage;
                this.CardHealth = 0;
            }
            else
            {
                this.Damage = 0;
                this.CardHealth = cardHealth;
            }

        }
    }
}
