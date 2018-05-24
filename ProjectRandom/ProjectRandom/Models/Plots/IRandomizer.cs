using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectRandom.Models.Plots
{
    interface IRandomizer <T> where T: class
    {
        // Maybe replace with GetRandom() then
        ///// <summary>Randomizes the constructor</summary>
        ///// <returns>Random object</returns>
        //T CreateRandom();

        /// <summary>Get a random object</summary>
        /// <returns>Random object</returns>
        T GetRandom();
    }
}
