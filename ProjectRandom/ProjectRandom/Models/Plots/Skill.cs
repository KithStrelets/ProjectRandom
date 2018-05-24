using ProjectRandom.Models.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectRandom.Models.Plots
{
    // ToDo: 1. Make props readonly
    //       2. Add methods for readonly props
    //       3. Add documentation
    public class Skill
    {
        string skillName;

        // ToDo: Change object --> image type
        object skillPicture;

        string skillDescription;

        // A mirror of characteristics
        Characteristic skillType;

        public string SkillName => skillName;

        public object SkillPicture => skillPicture;

        public string SkillDescription => skillDescription;

        public Characteristic SkillType => skillType;
    }
}
