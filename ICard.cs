using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabaCreatedWithTeamWork
{
    public interface ICard
    {

        string Name { get; init; }
        int Damage { get; init; }
        int CardHealth { get; init; }
        int CardHeal { get; init; }
    }
}
