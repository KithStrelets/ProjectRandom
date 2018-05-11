using System.Collections.Generic;

namespace ProjectRandom.Models
{
    // ToDo: Rewrite types and possibly add new mechanisms
    public interface IPlotMechanics
    {
        Map PlotMap { get; set; }

        /// <summary>Get a number of the current turn.</summary>
        /// <returns>Character object.</returns>
        int GetTurnNumber();

        int GetMoneyAmount();
        void SetMoneyAmount();

        Dictionary<object, int> GetTimer();
        void SetTimer(Dictionary<object, int> timer);
        void AddToTimer(object obj);

        /// <summary>Creates a random Character according to plot setting.</summary>
        /// <returns>Character object.</returns>
        object CreateCharacter();

        /// <summary>Choose the one out of proposed number of characters.</summary>
        /// <param name="numOfVariants">Number of proposed Character objects to choose.</param>
        /// <returns>Binds a selected character to a User.</returns>
        Dictionary<object, object> ChooseCharacter(int numOfVariants);

        /// <summary>Session lifecycle of events, turns, actions.</summary>
        void TurnsQueue();
    }
}
