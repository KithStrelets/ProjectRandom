using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectRandom.Models
{
    // A mirror of characteristics
    //enum SkillTypes
    //{
    //    Strength,
    //    Charisma,
    //    Intelligence,
    //    Agility,
    //    Luck
    //}

    // ToDo: 1. Make props readonly
    //       2. Add methods for readonly props
    //       3. Add documentation
    public class Skill
    {
        string skillName;

        // ToDo: Change object --> image type
        object skillPicture;

        string skillDescription;

        Characteristic skillType;
    }
}
