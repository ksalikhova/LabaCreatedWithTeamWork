﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabaCreatedWithTeamWork
{
    public class Creature : ICard, ICardHealth, IPower
    {
        public string Name { get; init;}
        public int Health { get ; init ;}
        public int Power { get ; init; }

        public Creature(string name, int health, int power)
        {
            Name = name; 
            Health = health;
            Power = power; 
        }
    }
}
