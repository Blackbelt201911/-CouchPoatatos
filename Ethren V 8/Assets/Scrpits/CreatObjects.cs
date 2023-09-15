using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class CreatObjects : MonoBehaviour
{
     public GameObject ObjectToSpawn;
     public Transform Placetospawn;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SpawnObject();
        }
    }
    void SpawnObject()
    {
        Instantiate(ObjectToSpawn, Placetospawn);
    }


}
