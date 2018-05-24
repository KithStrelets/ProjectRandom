using ProjectRandom.Models.Constants;
using ProjectRandom.Models.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectRandom.Models.Plots
{
    // ToDo: 1. Implement default behavior and values
    //       2. Add new features
    //       3. Documentation
    // ToDo: create method GetRandomCharacterName()
    // ToDo: create more Abstract methods for diversification of the plots
    // ToDo: IRandomizer fix
    public abstract class Character //: IRandomizer<Character>
    {
        string characterName;

        // ToDo: Change object --> image type
        object characterPicture;

        int healthPoints;

        int movementPoints;

        int age;

        Gender gender;

        int weight;

        int height;

        Race race;

        Dictionary<Characteristic, int> characteristicsSet;

        // Item --> amount!!!
        Dictionary<string, Item> inventory;

        // Head, Chest, Arms, Belt, Legs, Weapon --> While in list add their values to characteristics
        Dictionary<string, Item> equipment;

        // While in list add their values to characteristics
        List<Buff> buffSet;

        // ToDo: Think about a global replacement with randomizer
        protected Random rnd = new Random();

        protected Character()
        {
            characterName = GetRandomCharacterName();
            // ToDo: Change pic object
            characterPicture = new object();
            healthPoints = 100;
            movementPoints = 100;
            age = GetRandomAge();
            gender = GetRandomGender();
            weight = GetRandomWeight();
            height = GetRandomHeight();
            // ToDo: Implement a db fetch method and make setting through the property to accept all buffs
            race = Race.GetRandomRace();
            characteristicsSet = GetRandomCharacteristics();
            inventory = new Dictionary<string, Item>();
            equipment = new Dictionary<string, Item>();
            buffSet = new List<Buff>();
        }

        // --- Random getters ---

        private string GetRandomCharacterName() => "random name";

        private int GetRandomAge() => rnd.Next(14, 100);

        private Gender GetRandomGender() => (Gender)rnd.Next(0, 2);

        private int GetRandomWeight() => rnd.Next(20, 200);

        private int GetRandomHeight() => rnd.Next(100, 300);

        private Dictionary<Characteristic, int> GetRandomCharacteristics()
        {
            // ToDo: Make it more good-looking code and make dependencies on the Char race and plot const features
            // like --> if (Enum.IsDefined(typeof(MyEnum), 3)) { ... }
            int pointsPerCharacterLimit = CHARACTERISTICS_PLOT_POINTS_LIMIT;
            int CHARACTERISTIC_TYPE_UPPER_INDEX = 4;
            Dictionary<Characteristic, int> randomCharacteristicsSet = new Dictionary<Characteristic, int>();

            while (CHARACTERISTIC_TYPE_UPPER_INDEX >= 0)
            {
                var val = rnd.Next(1, pointsPerCharacterLimit);
                pointsPerCharacterLimit -= val;
                randomCharacteristicsSet.Add((Characteristic)CHARACTERISTIC_TYPE_UPPER_INDEX, val);
                CHARACTERISTIC_TYPE_UPPER_INDEX--;
            }

            return randomCharacteristicsSet;
        }

        // --- Default props ---

        public string CharacterName { get => characterName; set => characterName = value; }

        public object CharacterPicture => characterPicture;

        public int HealthPoints { get => healthPoints; set => healthPoints = value; }

        public int MovementPoints { get => movementPoints; set => movementPoints = value; }

        public int Age { get => age; set => age = value; }

        public Gender Gender { get => gender; set => gender = value; }

        public int Weight { get => weight; set => weight = value; }

        public int Height { get => height; set => height = value; }

        public Race Race { get => race; set => race = value; }

        public Dictionary<Characteristic, int> CharacteristicsSet { get => characteristicsSet; set => characteristicsSet = value; }

        public Dictionary<string, Item> Inventory => inventory;

        public Dictionary<string, Item> Equipment => equipment;

        List<Buff> BuffSet { get => buffSet; set => buffSet = value; }

        // --- Abstract section ---

        public abstract int CHARACTERISTICS_PLOT_POINTS_LIMIT { get; }

        //public abstract Dictionary<Characteristic, int> GetRandomCharacteristics();

        // In different plots different creation process
        public abstract Character CreateRandom();

        // In different plots different behavior
        public abstract int GetMaxHealthPoints();
    }
}
