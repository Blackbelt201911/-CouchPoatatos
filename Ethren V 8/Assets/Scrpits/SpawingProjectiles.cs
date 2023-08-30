using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental;
using UnityEngine;

public class MovingProjectiles : MonoBehaviour
{
    public Transform firingPoint;//where your shoting
    public GameObject ammoType; //waht your shooting
    public float timeAlive; // time bullet is alive in scen
    public float shotCounter; //dose fire rate stuff
   

    // Start is called before the first frame update
    void Start()
    {
        shotCounter = Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))//takes input
        {
            if (shotCounter <= 1)//dose fire rate stuff
            {
                shotCounter = 0;
                spawnBullet();//shoots   
            }
            
        }
    }

    void spawnBullet() { 
        Instantiate(ammoType, firingPoint.position, firingPoint.rotation); //Creats a bullet
    }
}
