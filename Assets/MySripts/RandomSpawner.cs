using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
   // public Vector3 spawnPoint;
    //public float spawnPointRange;
    public GameObject Prefab;
    public float Radius = 1;
    // Start is called before the first frame update
    void Start()
    {
        //this one works
        //Instantiate(Prefab, transform.position, Quaternion.identity);
        //new Vector3(transform.position.x + randomX, transform.position.y, transform.position.z + randomZ);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //private void SpawnPoint()
    //{
    //    //CALCULATE RANDOM POINT IN RANGE
    //    float randomZ = Random.Range(-spawnPointRange, spawnPointRange);
    //    float randomX = Random.Range(-spawnPointRange, spawnPointRange);

    //    spawnPointRange = new Vector3(transform.position.x,transform.position. z);

       

    //}
}
