namespace ProjectRandom.Models
{
    // ToDo: Rewrite types and possibly add new mechanisms
    public interface IPlotMechanics
    {
        /// <summary>Creates a random Character according to plot setting.</summary>
        /// <returns>Character object.</returns>
        object CharacterCreation();

        /// <summary>Choose the one out of proposed number of characters.</summary>
        /// <param name="createdCharacters">Collection of proposed Character objects.</param>
        /// <returns>Binds a selected character to a User.</returns>
        void CharacterChoosing(object[] createdCharacters);

        /// <summary>Session lifecycle of events, turns, actions.</summary>
        void TurnsQueue();
    }
}
