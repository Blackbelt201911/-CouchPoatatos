using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.EventSystems;

public class moveingProjectiles : MonoBehaviour
{
    public Rigidbody2D rb;
    public float bulletSpeed = 5;
    GameObject fireObject;
       

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(bulletSpeed ,0f);
        Destroy(gameObject, 5f);
    
    
    }


}
