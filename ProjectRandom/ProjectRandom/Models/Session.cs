using System;
using System.Collections.Generic;

namespace ProjectRandom.Models
{
    // ToDo: Add session constructor and other fields, add lazy load to init session
    //       only after all users are connected and make it possible to resize a session
    //       number of users;
    //       Make possible to change session open/closed state

    public class Session
    {
        /// <summary>Roles of users (GM or player).</summary>
        Dictionary<object, object> inSessionUsers;

        /// <summary>A set of plot mechanics to use.</summary>
        IPlotMechanics sessionPlot;

        private void SelectSessionPlotMechanics(Plot plot)
        {
            sessionPlot = (plot == Plot.Freerun) ? new FreerunPlot() :
                          //(plot == Plot.Medieval) ? new MedievalPlot() :
                          //(plot == Plot.Cyberpunk) ? new CyberpunkPlot() :
        // ToDo: Replace exception throw with smth else
                          throw new Exception("Error! Unimplemented plot or missing a value.");
        }

        /// <summary>Load a cached session from memory (or from a local path).</summary>
        /// <returns>Session saved state.</returns>
        public static Session GetCachedCopy()
        {
            // ToDo: Complete deserialization of cached object
            return new Session();
        }

        // ToDo: Ensure to save cached copy to database, add destruction of inactive sessions
        ~Session()
        {

        }
    }
}
