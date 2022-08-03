using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;


public class Treelife : MonoBehaviour
{
    public float health = 100;
    public GameObject tree;
   
    public bool treeDead;
    // public Treelife treelife;

    



    void Start()
    {
        
        tree = transform.gameObject;
        health = 100;
        treeDead = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            treeDead = true;
            
            //GetComponent<SpawnItem>();
            Rigidbody rb = tree.GetComponent<Rigidbody>();

            rb.isKinematic = false;
            rb.useGravity = true;
            rb.AddForce(Vector3.forward, ForceMode.Impulse);

            StartCoroutine(DestroyTree());
           


        }
    }
    

    public IEnumerator DestroyTree()
    {
        
       
         GetComponent<SpawnItem>();
        yield return new WaitForSeconds(4);
        GetComponent<SpawnItem>();
        yield return new WaitForSeconds(1);
        Destroy(gameObject);




    }


}

