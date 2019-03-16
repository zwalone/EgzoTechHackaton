using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// Container class for Lanes
/// </summary>
public class LaneContainer : MonoBehaviour
{
    [SerializeField]
    public int num_lanes = 0;


    List<GameObject> Lanes;

    [SerializeField]
    GameObject lanePrefab;


    // Start is called before the first frame update
    //Creates desired number of lanes that can be switched between
    void Start()
    {
        for(int i = 0; i < num_lanes; i++)
        {
            GameObject lane = Instantiate(lanePrefab);
            lane.transform.SetParent(this.transform);
            lane.transform.position = new Vector3(0.5f * i, 0.5f, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
