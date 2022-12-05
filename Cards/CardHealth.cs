using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabaCreatedWithTeamWork
{
    internal class CardHealth :ICard, ICardHealth
    {
        public string Name { get; init;}
        public int Health { get; init; }

        public CardHealth(string name, int health)
        {
            Name = name;
            Health = health;
        }
    }
}
