using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpawnManager : MonoBehaviour
{
    private float startDelay = 2;
    private float spawnInterval = .05f;
    public GameObject[] bullets;
    private float spawnRangeX = 20;
    // Start is called before the first frame update
    void Start()
    {
     
            InvokeRepeating("BulletSpawn", startDelay, spawnInterval);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void BulletSpawn()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 1, spawnRangeX);
        Instantiate(bullets[0], spawnPos, bullets[0].transform.rotation);
}
}
