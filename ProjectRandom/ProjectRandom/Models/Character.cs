using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectRandom.Models
{
    // ToDo: 1. Implement default behavior and values
    //       2. Add new features
    abstract class Character
    {
        string characterName;
        // ToDo: Change object --> image type
        object characterPicture;
        int healthPoints;
        int movementPoints;
        int experiencePoints;
        int age;
        Gender gender;
        int weight;
        int height;
        Race race;
        // Skill --> name, desc, skilltype (depends on characteristics)
        List<Skill> skills;
        Dictionary<Characteristic, int> characteristicsSet;
        // Item --> amount!!!
        Dictionary<string, Item> inventory;
        // Head, Chest, Arms, Belt, Legs, Weapon --> While in list add their values to characteristics
        Dictionary<string, Item> equipment;
        // While in list add their values to characteristics
        List<Buff> buffSet;

        // In different plots different behavior
        public abstract int GetMaxHealthPoints();
        //{
        //    // ToDo: Complete default value implementation
        //    return 1;
        //}
    }
}
