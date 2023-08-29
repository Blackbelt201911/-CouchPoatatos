using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shieldScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePosition = Input.mousePosition; //I stole this idk how it works
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition); //I stole this idk how it works

        Vector2 dirction = new Vector2(mousePosition.x - transform.position.x, mousePosition.y - transform.position.y);

        transform.up = dirction;
    }
}
