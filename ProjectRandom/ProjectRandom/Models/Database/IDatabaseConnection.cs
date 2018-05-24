namespace ProjectRandom.Models.Database
{
    // ToDo: Change types of params, add more funcs according to session flow
    public interface IDatabaseConnection
    {
        /// <summary>Get the full list of created room sessions.</summary>
        /// <returns>Json array of sessions.</returns>
        string GetAllSessions();

        /// <summary>Get the room session by the session id.</summary>
        /// <param name="identificator">Session id.</param>
        /// <returns>Json session object.</returns>
        string GetSession(object identificator);

        /// <summary>Get a random item of exact type.</summary>
        /// <param name="collection">Choose a type of item.</param>
        /// <returns>Json item object.</returns>
        string GetRandomItem(object collection);

        /// <summary>Get a random buff.</summary>
        /// <param name="type">Choose a buff type (positive or negative).</param>
        /// <returns>Json buff object.</returns>
        string GetRandomBuff(object type);

        /// <summary>Get a random skill.</summary>
        /// <param name="characteristic">Choose a skill tree (strength/charisma/intelligence/agility/luck).</param>
        /// <returns>Json skill object.</returns>
        string GetRandomSkill(object characteristic);
    }
}
