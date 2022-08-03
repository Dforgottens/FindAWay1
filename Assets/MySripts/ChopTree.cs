using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


[System.Serializable]

public class ChopTree : MonoBehaviour
{

    public delegate void ModifiedEvent();


    public Camera FPSCamera;

    public float hitRange = 2.5f;
    GameObject Player;
    private Treelife treelife;
    public int Damage; 


    




    void Start()
    {
        Player = GameObject.Find("Player");
       
    }

    public void Update()
    {
        Damage = GetComponent<Player>().attributes[3].value.ModifiedValue;
        
        Ray ray = FPSCamera.ScreenPointToRay(new Vector2(Screen.width / 2, Screen.height / 2));
        RaycastHit hitInfo;

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if(Physics. Raycast(ray, out hitInfo, hitRange))
            {
                if(hitInfo.collider.tag == "tree")
                {
                    treelife = hitInfo.collider.GetComponentInParent<Treelife>();
                    
                    DamageTreelife();

                }
            }
        }
    }

   
    void DamageTreelife()
    {

        //treelife.health -= Damage;
        treelife.health -= Damage;

    }

}
