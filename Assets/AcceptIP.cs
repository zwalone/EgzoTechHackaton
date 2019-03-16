using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AcceptIP : MonoBehaviour
{

    InputField field;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Connect()
    {
        EgzoController.instance.EstablishConnection(field.text);
    }
}
