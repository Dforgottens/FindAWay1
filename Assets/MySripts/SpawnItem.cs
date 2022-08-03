using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnItem : MonoBehaviour
{
    public GameObject GroundItem;
    GameObject tree;
    // Start is called before the first frame update
    void Start()
    {
        //Change ground item to whatever you want to spawn in 
        Instantiate(GroundItem, transform.position, Quaternion.identity);
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    
        

}
