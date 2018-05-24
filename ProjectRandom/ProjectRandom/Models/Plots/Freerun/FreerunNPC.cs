using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectRandom.Models.Constants;

namespace ProjectRandom.Models.Plots.Freerun
{
    // ToDo: complete concrete npc with plot limits
    // ToDo: fulfill with database fetches of the freerun plot and make limits of the plot
    public class FreerunNPC : NPC
    {
        public override int CHARACTERISTICS_PLOT_POINTS_LIMIT => 10;

        public override Character CreateRandom()
        {
            // Customize randomizer
            return new FreerunNPC();
        }

    }
}
