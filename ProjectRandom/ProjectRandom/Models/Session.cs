using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectRandom.Models
{
    // ToDo: Add session constructor and other fields
    public class Session
    {
        /// <summary>Roles of users (GM or player).</summary>
        Dictionary<object, object> inSessionUsers;

        /// <summary>A set of plot mechanics to use.</summary>
        IPlotMechanics sessionPlot;

    }
}
