using ProjectRandom.Models.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectRandom.Models.Plots
{
    // ToDo: 1. Make props readonly
    //       2. Add methods for readonly props
    //       3. Add documentation
    public class Race
    {
        string raceName;

        // ToDo: Change object --> image type
        object racePicture;

        string raceDescription;

        // ToDo: Make static collection of races
        internal static Race GetRandomRace()
        {
            return MongoConnection.GetInstance().GetRandomRace();
        }

        public string RaceName => raceName;

        public object RacePicture => racePicture;

        public string RaceDescription => raceDescription;
    }
}
