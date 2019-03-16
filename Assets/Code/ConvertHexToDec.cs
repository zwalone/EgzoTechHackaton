using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ConvertHexToDec
{
    private static int HexToDec(string hex)
    {
        int dec = System.Convert.ToInt32(hex, 16);
        return dec;
    }

    private static float HexToFloatNormalized(string hex)
    {
        return HexToDec(hex) / 255f;
    }
    public static Color GetColorfromString(string hexstring)
    {
        float red = HexToFloatNormalized(hexstring.Substring(0, 2));
        float green = HexToFloatNormalized(hexstring.Substring(2, 2));
        float blue = HexToFloatNormalized(hexstring.Substring(4, 2));
        return new Color(red , green, blue);
    }
}
