using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controllerscrpt : MonoBehaviour
{
    public float movespeed;
    public Rigidbody2D rb;
    private Vector2 MovementDiction;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Inputmanger();
    }
    private void FixedUpdate()
    {
        Move();
    }
    void Inputmanger()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        MovementDiction = new Vector2(moveX, moveY);
    } 

    void Move()
    {
        rb.velocity = new Vector2(MovementDiction.x * movespeed, MovementDiction.y * movespeed); 
    }

}
