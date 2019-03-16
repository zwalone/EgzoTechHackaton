using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// UI utility class - provides function for button, to connect EgzoController to LUNA via IP address
/// </summary>
public class AcceptIP : MonoBehaviour
{
    [SerializeField]
    InputField field;

    public void Connect()
    {
        EgzoController.instance.EstablishConnection(field.text);
    }
}
