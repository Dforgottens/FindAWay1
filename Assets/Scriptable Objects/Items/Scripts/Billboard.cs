using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard : MonoBehaviour
{
    //public Camera _camera;
   // Player player;
    //public GameObject Camera;

    

    private void Start()
    {
        
        
        
    }


    private void Update()
    {
        transform.forward = Camera.main.transform.forward;
    }
    //private void LateUpdate()
    //{
    //    //this for when you have items all ready in scene
    //   // transform.forward =  _camera.transform.forward;
    //}
}