//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class TreePool : MonoBehaviour
//{
//   static int numTrees = 5;
//    public GameObject treePrefab;
//    static GameObject[] trees;
   
//    void Start()
//    {
//        trees = new GameObject[numTrees];
//        for (int i = 0; i < numTrees; i++)
//        {
//            trees[i] = (GameObject)Instantiate(treePrefab, Vector3.zero, Quaternion.identity);
//            trees[i].SetActive(false);
//        }
//    }

//  static public GameObject getTree()
//    {
//        for (int i = 0; i < numTrees; i++)
//        {
//            if (!trees[i].activeSelf)
//            {
//                return trees[i];
               
//            }
//        }
//        return null;
//    }
//    void Update()
//    {
        
//    }
   
//}
