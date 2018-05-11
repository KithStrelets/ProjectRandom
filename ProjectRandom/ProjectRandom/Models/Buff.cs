using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectRandom.Models
{
    // ToDo: 1. Make props readonly
    //       2. Add methods for readonly props
    //       3. Add method for switching a sign buff value depending on BuffType
    //       4. Maybe set a prop of continuation inside of this class instead of fulfilling the Session Timer
    //       5. Add documentation
    public class Buff
    {
        string buffName;

        // ToDo: Change object --> image type
        object buffPicture;

        string buffDescription;

        Characteristic? buffSpecialization;

        int buffValue;
    }
}
