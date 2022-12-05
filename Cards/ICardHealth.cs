using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabaCreatedWithTeamWork
{
    public interface ICardHealth: ICard
    {
        int Health { get; init; }
    }
}
