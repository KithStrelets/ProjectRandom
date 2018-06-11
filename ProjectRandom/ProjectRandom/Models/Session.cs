using ProjectRandom.Models.Constants;
using System;
using System.Collections.Generic;
using ProjectRandom.Models.Plots.Freerun;
using ProjectRandom.Models.Plots;

namespace ProjectRandom.Models
{
    // ToDo: Add session constructor and other fields, add lazy load to init session
    //       only after all users are connected and make it possible to resize a session
    //       number of users;
    //       Make possible to change session open/closed state

    public class Session
    {
        // ToDo: Documentation
        // May become useless
        Guid sessionId;

        SessionState state;

        // ToDo: Think about GM role realization --> need an empty obj?
        /// <summary>Roles of users (GM or player).</summary>
        Dictionary<object, object> inSessionUsers;

        /// <summary>A set of plot mechanics to use.</summary>
        IPlotMechanics sessionPlot;

        private void SelectSessionPlotMechanics(Plot plot)
        {
            sessionPlot = (plot == Plot.Freerun) ? new FreerunPlot(inSessionUsers) :
                          //(plot == Plot.Medieval) ? new MedievalPlot(inSessionUsers) :
                          //(plot == Plot.Cyberpunk) ? new CyberpunkPlot(inSessionUsers) :
                          
                          // ToDo: Replace exception throw with smth else
                          throw new Exception("Error! Unimplemented plot or a missing value.");
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
