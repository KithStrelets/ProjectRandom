using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectRandom.Models.Plots
{
    // ToDo: Implement the other abstractions
    //       Documentation
    public abstract class NPC : Character
    {
        // ToDo: correct a default value for npc
        public override int GetMaxHealthPoints() => 100;

        // Other NPC specs...
    }
}
