using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectRandom.Models
{
    // Load copies of the active sessions' plot maps to the server memory
    // and change only the coords on the copy/reference of the map from the set
    public abstract class Map
    {
        string mapName;

        (int, int) currentLocation;

        (int, int) startLocation;

        // ToDo: Change object --> image type
        object mapPicture;

        public abstract void MapLoad();

        public abstract void MapSave();
    }
}
