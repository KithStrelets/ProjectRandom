using System.Collections.Generic;

namespace ProjectRandom.Models.Plots
{
    // ToDo: Rewrite types and possibly add new mechanisms
    //       Documentation
    public interface IPlotMechanics
    {
        Map PlotMap { get; set; }

        /// <summary>Get a number of the current world turn.</summary>
        /// <returns>Turn number.</returns>
        int TurnNumber { get; set; }

        int MoneyAmount { get; set; }

        Dictionary<object, int> Timer { get; set; }
        void AddToTimer(object obj, int turnsDuration);

        // ToDo: Replace object with User class
        Dictionary<Player, object> RegisteredPlayerCharacters { get; set; }

        List<Player> ActivePlayers { get; set; }

        List<Character> CurrentEnemies { get; set; }

        /// <summary>Creates a random Player according to plot setting.</summary>
        /// <returns>Player object.</returns>
        Player CreatePlayer();

        /// <summary>Creates a random NPC according to plot setting.</summary>
        /// <returns>NPC object.</returns>
        NPC CreateNPC();

        /// <summary>Choose the one out of proposed number of characters.</summary>
        /// <param name="numOfVariants">Number of proposed Player objects to choose.</param>
        /// <returns>Binds a selected character to a User.</returns>
        Dictionary<object, object> ChoosePlayerCharacter(int numOfVariants);

        // ToDo: Replace with a simple(linked) list
        // ToDo: Trigger all calculations inside of the character and the whole world
        /// <summary>Lifecycle of events, turns, actions in 1 world turn.</summary>
        Queue<object> TurnsQueue { get; }

        // ToDo: Think about the interaction with TurnsQueue
        void NextTurn();

        // ToDo: Necessary to reorder after a new connection/disconnect of a player or after unboxing from the db
        void QueueReorder(object inSessionPlayers);

        Dictionary<string, Item> GetRandomInventory();

        Dictionary<string, Item> GetRandomEquipment();

        // In different plots different collections to take items from
        Item GetPlotRandomItem();
    }
}
