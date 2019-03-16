using UnityEngine;
using System.Collections.Generic;


public static class RandomUtils
{
    public static T GetRandomElement<T>(List<T> set)
    {
        return set[Random.Range(0, set.Count)];
    }
}

