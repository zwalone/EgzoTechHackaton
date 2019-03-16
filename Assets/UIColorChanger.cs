using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


/// <summary>
/// Changes color of UI when block color change occurs
/// </summary>
public class UIColorChanger : MonoBehaviour
{
    [SerializeField]
    Image i;
    // Start is called before the first frame update
    void Start()
    {
        Block.colorChanged += UpdateColor;
    }

    void UpdateColor(Color _c)
    {
        i.color = _c;
    }
}
