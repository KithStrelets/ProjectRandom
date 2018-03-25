using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectRandom.Models
{
    // ToDo: Add session constructor and other fields, add lazy load to init session
    //       only after all users are connected and make it possible to resize a session
    //       number of users

    public class Session
    {
        /// <summary>Roles of users (GM or player).</summary>
        Dictionary<object, object> inSessionUsers;

        /// <summary>A set of plot mechanics to use.</summary>
        IPlotMechanics sessionPlot;

        /// <summary>Load a cached session from memory (or from a local path).</summary>
        /// <param name="idSession">Choose a skill tree (strength/charisma/intelligence/agility/luck).</param>
        /// <returns>Json skill object.</returns>
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
