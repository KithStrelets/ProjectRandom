using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectRandom.Models.Plots
{
    // ToDo: Documentation
    public abstract class Player : Character
    {
        int experiencePoints;

        string biography;

        // Skill --> name, desc, skilltype (depends on characteristics)
        List<Skill> skills;

        public Player() : base()
        {
            // ToDo: implement a normal constructor
            biography = RandomBiography;
        }

        // ToDo: Implement db method
        private string RandomBiography => "random Bio";

        // Might be useless
        //public string Biography { get => biography; set => biography = value; }

        // ToDo: Make dependencies with Race
        public int ExperiencePoints { get => experiencePoints; set => experiencePoints = value; }

        public string Biography { get => biography; set => biography = value; }

        public List<Skill> Skills { get => skills; set => skills = value; }

        // ToDo: CREATE RANDOMIZER
        //public static Player RandomPlayer() => new Player();

        protected abstract int GetPlotMaxHPBonus();

        // ToDo: return a value that depends on player stats
        public override int GetMaxHealthPoints() => 100 + GetPlotMaxHPBonus();

    }
}
