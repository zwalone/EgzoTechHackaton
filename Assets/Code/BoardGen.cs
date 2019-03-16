using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Script that generates block that will fall in the board
public class BoardGen : MonoBehaviour
{
    [SerializeField]
    LaneContainer laneContainer;
    [SerializeField]
    Filter filter;
    [SerializeField]
    GameObject blockPrefab;

    [SerializeField]
    float min_length = 6f;
    [SerializeField]
    float max_length = 10f;

    [SerializeField]
    int lastLaneNumber = 4;

    [SerializeField]
    float minConnectivityZone = 3f;

    float time = 0f;
    float spawn_time = 1f;

    float spawnOriginZ = 20f;

    GameObject lastSpawnedBlock;



    // Start is called before the first frame update
    void Start()
    {
        //spawn first block in the middle
        GenerateNewBlock(2, 25);
        filter.BlockEntered += UpdateSpawn;
    }

    //Generates random block on random lane
    void GenerateNewBlock(int lane_num, float connection_additive)
    {
        Debug.Log(lane_num);
        Transform lane = laneContainer.transform.GetChild(lane_num);


        //Then instantiate prefab block and set it's length
        GameObject block = Instantiate(blockPrefab);
        block.transform.SetParent(lane);
        block.GetComponent<Block>().laneNum = lane_num;
        //set block at desired origin point
        block.transform.localPosition = new Vector3(0, 0.3f, connection_additive);
        block.GetComponentInChildren<SpriteRenderer>().sortingOrder = lane_num % 2;


        //Randomize length of a block
        float length = UnityEngine.Random.Range(min_length, max_length);
        block.GetComponent<Block>().length = length;
        block.transform.localScale = new Vector3(1, 1, length);
        lastSpawnedBlock = block;
    }

    void UpdateSpawn(Block b)
    {
        //Assure connectivity bettween the blocks
        //if the blocks are on diffrent lanes determine 
        if (b != null)
        {
            //determine lane direction and Connection Additive
            float connection_additive = b.transform.localPosition.z + UnityEngine.Random.Range(2f, b.GetComponent<Block>().length/2);
            //two first ifs check border conditions, last one else randomizes driection (middle cases)
            if (b.GetComponent<Block>().laneNum == 0)
            {
                //if on far left go right
                GenerateNewBlock(1, connection_additive);

            }
            else if (b.GetComponent<Block>().laneNum >= lastLaneNumber)
            {

                GenerateNewBlock(lastLaneNumber - 1, connection_additive);
            }
            else
            {
                GenerateNewBlock(b.GetComponent<Block>().laneNum + RandomUtils.GetRandomElement(new List<int>() {-1, 1 }), connection_additive);
            }

        }
    }


}
