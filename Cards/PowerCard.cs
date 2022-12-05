using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabaCreatedWithTeamWork
{
    internal class PowerCard : ICard, IPower
    {
        public string Name { get;init;}
        public int Power { get; init; }


        public PowerCard(string name, int power)
        {
            Name = name;
            Power = power;
        }
    }
}
