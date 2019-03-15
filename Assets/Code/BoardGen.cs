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
    float min_length = 3f;
    [SerializeField]
    float max_length = 10f;

    [SerializeField]
    int lastLaneNumber = 5;

    [SerializeField]
    float minConnectivityZone = 3f;

    float time = 0f;
    float spawn_time = 1f;

    float spawnOriginZ = 20f;

    GameObject lastSpawnedBlock;

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


        //Then instantiate prefab block and set it's length
        GameObject block = Instantiate(blockPrefab);
        block.transform.SetParent(lane);
        //spawn block at desired origin point
        block.transform.localPosition = new Vector3(0, 0.3f, spawnOriginZ);

        //Randomize length of a block
        float length = UnityEngine.Random.Range(min_length, max_length);
        block.transform.localScale = new Vector3(1, 1, length);


        //Determine front and end of the block
        Vector3 front = new Vector3(0, 0, transform.position.z - (length/2));
        Vector3 end = new Vector3(0, 0, transform.position.z + (length/2));



        //Assure connectivity bettween the blocks
        //if the blocks are on diffrent lanes determine 
        if(lastSpawnedBlock != null)
        { 
        
        }






    }
}
