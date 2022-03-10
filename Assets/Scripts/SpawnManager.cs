using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject  obstaclePrefab;
    public GameObject obstaclePrefabB;
    private Vector3 spawnPos = new Vector3(25f, 2.1f ,0f);
    private Vector3 spawnPosB = new Vector3(25f, 0.2f ,-1.5f);
    private float startDelay = 2;
    private float startDelayB = 8.5f;
    private float repeatRate = 2;
    private float repeatRateB = 8.5f;
    private PlayerController playerControllerScript;


    // Start is called before the first frame update
    void Start()
    {
       
        InvokeRepeating("SpawnObstacles", startDelay, repeatRate);
        InvokeRepeating("SpawnObstaclesB", startDelayB, repeatRateB);
        
        playerControllerScript =
        GameObject.Find("Player").GetComponent<PlayerController>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacles()
    {
        if(playerControllerScript.GameOver == false)
        Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
        
}
 void SpawnObstaclesB()
    {
        if(playerControllerScript.GameOver == false)
       
        Instantiate(obstaclePrefabB, spawnPosB, obstaclePrefabB.transform.rotation);
}


}
