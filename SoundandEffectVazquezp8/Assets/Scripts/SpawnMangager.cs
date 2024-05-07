using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMangager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    private float startDelay = 2;
    private float repeatRate = 2;
    private PlayerController controller;
    private int randomObstacle;
    // Start is called before the first frame update
    void Start()
    {
        controller = GameObject.Find("Player").GetComponent<PlayerController>();
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacle ()
    {
        if(controller.gameOver == false)
        {
            randomObstacle = Random.Range(0, obstaclePrefab.Length);
           Instantiate(obstaclePrefabs [randomObstacle], spawnPos, obstaclePrefab[randomObstacle].transform.rotyation);
        }
      
    }
}
