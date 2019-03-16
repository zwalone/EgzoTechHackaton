using UnityEngine;
using System.Collections.Generic;


/// <summary>
/// Utility class - Contains functions that are usefull for randomizing stuff
/// </summary>
public static class RandomUtils
{
    /// <summary>
    /// Gets the random element from a given set
    /// </summary>
    /// <returns>The random element.</returns>
    /// <param name="set">Set.</param>
    /// <typeparam name="T">The 1st type parameter.</typeparam>
    public static T GetRandomElement<T>(List<T> set)
    {
        return set[Random.Range(0, set.Count)];
    }
}

