using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    internal interface ICard
    {

        string Name { get; init; }
        int Damage { get; init; }
        int CardHealth { get; init; }
    }
}
