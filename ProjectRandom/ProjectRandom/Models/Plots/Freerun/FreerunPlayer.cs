using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectRandom.Models.Constants;

namespace ProjectRandom.Models.Plots.Freerun
{
    public class FreerunPlayer : Player
    {
        public override int CHARACTERISTICS_PLOT_POINTS_LIMIT => 15;

        public override Character CreateRandom()
        {
            // Customize randomizer
            return new FreerunPlayer();
        }

        // ToDo: fulfill with database fetches of the freerun plot and make limits of the plot

        protected override int GetPlotMaxHPBonus()
        {
            return 111;
        }
    }
}
