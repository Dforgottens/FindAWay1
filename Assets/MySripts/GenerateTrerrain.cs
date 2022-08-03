//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class GenerateTrerrain : MonoBehaviour
//{
//    int heightScale = 5;
//    float detailScale = 5.0f;
//    List<GameObject> myTrees = new List<GameObject>();




//    // Start is called before the first frame update
//    void Start()
//    {
//        Mesh mesh = this.GetComponent<MeshFilter>().mesh;
//        Vector3[] vertices = mesh.vertices;
//        for (int v = 0; v < vertices.Length; v++)
//        {
//            vertices[v].y = Mathf.PerlinNoise((vertices[v].x + this.transform.position.x) / detailScale,
//                                               (vertices[v].z + this.transform.position.z) / detailScale) * heightScale;

//            if (vertices[v].y > 0)
//            {
//                GameObject newTree = TreePool.getTree();
//                if (newTree != null)
//                {
//                    Vector3 treePos = new Vector3(vertices[v].x + this.transform.position.x,
//                                                   vertices[v].y,
//                                                   vertices[v].z + this.transform.position.z);
//                    newTree.transform.position = treePos;
//                    newTree.SetActive(true);
//                    myTrees.Add(newTree);
//                }
//            }
//        }
//    }

//    public void OnDestroy()
//    {
//        for (int i = 0; i < myTrees.Count; i++)
//        {
//            if (myTrees[i] != null)
//                myTrees[i].SetActive(false);
//            myTrees.Clear();
//        }
//    }
//}
