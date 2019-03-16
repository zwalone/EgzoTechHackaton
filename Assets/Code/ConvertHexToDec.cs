using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConvertHexToDec : MonoBehaviour
{
    private int HexToDec(string hex)
    {
        int dec = System.Convert.ToInt32(hex, 16);
        return dec;
    }

    private float HexToFloatNormalized(string hex)
    {
        return HexToDec(hex) / 255f;
    }
    public Color GetColorfromString(string hexstring)
    {
        float red = HexToFloatNormalized(hexstring.Substring(0, 2));
        float green = HexToFloatNormalized(hexstring.Substring(2, 2));
        float blue = HexToFloatNormalized(hexstring.Substring(4, 2));
        return new Color(red , green, blue);
    }
}
