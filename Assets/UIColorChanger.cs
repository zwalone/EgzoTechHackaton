using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIColorChanger : MonoBehaviour
{
    [SerializeField]
    Image i;
    // Start is called before the first frame update
    void Start()
    {
        Block.colorChanged += UpdateColor;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void UpdateColor(Color _c)
    {
        i.color = _c;
    }
}
