using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabaCreatedWithTeamWork
{
    internal class CardHeal : ICard, ICardHeal
    {
        public string Name { get; init; }
        public int Heal { get ; init ; }

        public CardHeal(string name,int heal)
        {
            Name = name;
            Heal = heal;
        }
    }
}
