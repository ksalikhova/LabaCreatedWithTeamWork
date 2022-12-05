using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabaCreatedWithTeamWork
{
    public interface IPower : ICard
    {
        int Power { get; init; }
    }
}
