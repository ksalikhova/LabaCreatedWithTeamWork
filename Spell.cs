using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabaCreatedWithTeamWork
{
    public class Spell : Card
    {
        public enum SpellType
        {
            Power,
            Protection,
            Heal
        }



        public Spell(SpellType type, string name, int damage, int cardHealth, int cardHeal) : base(name, damage, cardHealth, cardHeal)
        {

            this.Name = name;
            switch(type ) 
            {
                case SpellType.Power:
                    this.Damage = damage;
                    break;
                    case SpellType.Protection: 
                    this.CardHealth = cardHealth;
                    break;
                    case SpellType.Heal:
                    this.CardHeal = cardHealth;
                    break;
                    default:
                    break;
            }

        }
    }
}
