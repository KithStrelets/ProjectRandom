using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace ProjectRandom.Models.Plots.Freerun
{
    public class FreerunPlot : IPlotMechanics
    {
        FreerunMap plotMap;

        int turnNumber;

        int moneyAmount;

        Dictionary<object, int> timerContainer;

        Dictionary<Player, object> registeredPlayerCharacters;

        List<Player> activePlayers;

        List<Character> currentEnemies;

        // ToDo: Replace with a simple(linked) list
        Queue<object> turnsQueue;

        private object currentTargetOfAction;

        private FreerunPlot()
        {
            // Maybe make it a random location to start
            PlotMap = new FreerunMap();
            TurnNumber = 1;
            MoneyAmount = 0;
            // Initialize it through a manager of events which calculates every character
            Timer = new Dictionary<object, int>();
            RegisteredPlayerCharacters = new Dictionary<Player, object>();
            ActivePlayers = new List<Player>();
            CurrentEnemies = new List<Character>();
            TurnsQueue = new Queue<object>();
        }

        // ToDo: change object to collection type
        public FreerunPlot(object inSessionUsers) : this()
        {
            // ToDo: Function for selection from registeredPlayerCharacters, registering unregistered and addition inSessionPlayers to activePlayers
            // ToDo: Setup a turnsQueue
            
            QueueReorder(inSessionUsers);
        }

        // ToDo: Unbox Json object and use its props
        //public FreerunPlot(Map plotMap, int turnNumber, int moneyAmount, Dictionary<object, int> timer, List<Character> currentEnemies, List<Player> activePlayers)
        //{
        //    PlotMap = plotMap ?? throw new ArgumentNullException(nameof(plotMap));
        //    TurnNumber = turnNumber;
        //    MoneyAmount = moneyAmount;
        //    Timer = timer ?? throw new ArgumentNullException(nameof(timer));
        //    CurrentEnemies = currentEnemies ?? throw new ArgumentNullException(nameof(currentEnemies));
        //    ActivePlayers = activePlayers ?? throw new ArgumentNullException(nameof(activePlayers));
        //}

        // ToDo: insert into constructor new FreerunMap()
        public Map PlotMap { get => plotMap; set => plotMap = (FreerunMap)value; }

        public Dictionary<string, Item> GetRandomInventory()
        {
            Dictionary<string, Item> randomInventory = new Dictionary<string, Item>();
            // ToDo: Make it global abstract const
            int CONST_ITEM_COUNT = 5;
            while (CONST_ITEM_COUNT > 0)
            {
                Item randomItem = GetPlotRandomItem();
                randomInventory.Add(randomItem.ItemName, randomItem);
                CONST_ITEM_COUNT--;
            }

            return randomInventory;
        }

        public Dictionary<string, Item> GetRandomEquipment()
        {
            Dictionary<string, Item> randomEquipment = new Dictionary<string, Item>();
            Item randomItem;
            // ToDo: Make it more good-looking code 
            // like --> if (Enum.IsDefined(typeof(MyEnum), 3)) { ... }
            // Head, Chest, Arms, Belt, Legs, Weapon = {0 ... 5}
            // ToDo: Add 1 spare index chance that there's nothing equipped
            int EQUIPMENT_TYPE_UPPER_INDEX = 5;
            while (EQUIPMENT_TYPE_UPPER_INDEX >= 0)
            {
                // ToDo: PlotRandomItem of EQUIPMENT_TYPE_UPPER_INDEX type
                randomItem = GetPlotRandomItem();
                randomEquipment.Add(randomItem.ItemName, randomItem);
                EQUIPMENT_TYPE_UPPER_INDEX--;
            }

            return randomEquipment;
        }

        // ToDo: implement db method
        public Item GetPlotRandomItem() => new Item();

        public int TurnNumber { get => turnNumber; set => turnNumber = value; }

        public int MoneyAmount { get => moneyAmount; set => moneyAmount = value; }

        public Dictionary<object, int> Timer { get => timerContainer; set => timerContainer = value; }

        public Dictionary<Player, object> RegisteredPlayerCharacters { get => registeredPlayerCharacters; set => registeredPlayerCharacters = value; }

        public List<Character> CurrentEnemies { get => currentEnemies; set => currentEnemies = value; }

        public List<Player> ActivePlayers { get => activePlayers; set => activePlayers = value; }

        //public Queue<object> TurnsQueue => turnsQueue;
        public Queue<object> TurnsQueue { get => turnsQueue; set => turnsQueue = value; }

        // Maybe replace with randomizer
        public Player CreatePlayer()
        {
            // ToDo: Complete implementation
            return new FreerunPlayer();
        }

        // Maybe replace with randomizer
        public NPC CreateNPC()
        {
            // ToDo: Complete implementation
            return new FreerunNPC();
        }

        public Dictionary<object, object> ChoosePlayerCharacter(int numOfVariants)
        {
            // ToDo: Complete implementation
            return new Dictionary<object, object>();
        }

        public void AddToTimer(object obj, int turnsDuration)
        {
            Timer.Add(obj, turnsDuration);
        }

        // Use after controller action call like ending of the command
        public void NextTurn()
        {
            // ToDo: Check Timer and trigger every object in it
            // ... other plot options ...
            IEnumerator queueOfActiveObjects = TurnsQueue.GetEnumerator();

            if (queueOfActiveObjects.MoveNext())
                currentTargetOfAction = queueOfActiveObjects.Current;
            else
            {
                queueOfActiveObjects.Reset();
                if (queueOfActiveObjects.MoveNext())
                { 
                    currentTargetOfAction = queueOfActiveObjects.Current;
                    TurnNumber++;
                }
                else throw new System.Exception();
            }
        }

        public void QueueReorder(object inSessionUsers)
        {
            // ToDo: Change object to User type
            //List<object> unregisteredUsers = ((Dictionary<object, object>)inSessionUsers).Values.Except(RegisteredPlayerCharacters.Values).ToList();
            List<object> unregisteredUsers = ((List<object>)inSessionUsers).Except(RegisteredPlayerCharacters.Values).ToList();

            // ToDo: Think about foreach --> for() or while()
            if (unregisteredUsers.Count != 0)
                foreach (object unregUser in unregisteredUsers)
                {
                    NewPlayerRegistration(unregUser);
                }

            RefreshActivePlayers(inSessionUsers);
            // ToDo: Append default queue after players' turns
        }

        // ToDo: Change object to User type
        private void NewPlayerRegistration(object user)
        {
            // CharacterChoosing and linking
        }

        private void RefreshActivePlayers(object inSessionUsers)
        {
            // Needs to be tested!
            ActivePlayers = RegisteredPlayerCharacters.Where(pair => RegisteredPlayerCharacters.Values.Intersect((List<object>)inSessionUsers).Contains(pair.Value))
                                                      .Select(pair => pair.Key).ToList();
        }

    }
}
