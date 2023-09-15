using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class CreatObjects : MonoBehaviour
{
     public GameObject ObjectToSpawn;
     public Transform Placetospawn;
     public float DelayBetweenThrows = 5;
     float lastThrowDate;




    void Start()
    {
        lastThrowDate = Time.time;
    }
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
        if ((Time.time - lastThrowDate > DelayBetweenThrows))
        {
            Instantiate(ObjectToSpawn, Placetospawn);
            lastThrowDate = Time.time;
        }

    }


    

    




}
