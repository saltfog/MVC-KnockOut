using KnockOutSelectors.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KnockOutSelectors.Repository
{
    public interface IRepository
    {
        List<World> GetWorld();
    }
}
