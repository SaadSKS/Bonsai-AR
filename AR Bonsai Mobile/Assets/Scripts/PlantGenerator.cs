using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantGenerator : MonoBehaviour
{
    public GameObject Plant;
    Mesh rootMesh;

    void Start()
    {
        //Vertices, Normals, UVS, Triangles

        Vector3[] vertices = new Vector3[]
        {
            new Vector3(1,0,1),
            new Vector3(-1,0,1),
            new Vector3(1,0,-1),
            new Vector3(-1,0,-1),

        };

        


        //Create & Link Mesh
        rootMesh = new Mesh();
        rootMesh.Clear();
        rootMesh = Plant.GetComponent<MeshFilter>().mesh;
        
    }
    
}
