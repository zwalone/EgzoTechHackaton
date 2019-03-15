using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Script that generates block that will fall in the board
public class BoardGen : MonoBehaviour
{
    [SerializeField]
    LaneContainer laneContainer;
    [SerializeField]
    GameObject blockPrefab;

    [SerializeField]
    float min_length = 0f;
    [SerializeField]
    float max_length = 10f;

    [SerializeField]
    int lastLaneNumber = 5;


    float time = 0f;
    float spawn_time = 2f;

    GameObject lastSpawnedLane;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if(time >= spawn_time)
        {
            GenerateNewBlock();
            time = 0;
        }
    }


    //Generates random block on random lane
    void GenerateNewBlock()
    {
        //first, choose random lane
        int lane_num = UnityEngine.Random.Range(0, lastLaneNumber-1);
        Transform lane = laneContainer.transform.GetChild(lane_num);
       
        GameObject block = Instantiate(blockPrefab);
        block.transform.SetParent(lane);
        //Set the middle forward of a lane
        block.transform.localPosition = new Vector3(0, 0, 10);
        //Randomize length of a block
        float length = UnityEngine.Random.Range(min_length, max_length);
        block.transform.localScale = new Vector3(1,1, length);



        //Update
        //Task: make interconnected blocks

        //first get last generated block, and read it's border position
        //randomize connectivity length



    }
}
