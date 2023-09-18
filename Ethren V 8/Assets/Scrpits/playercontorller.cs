using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontorller : MonoBehaviour
{
    //How fast you move
    public int movespeed = 6;
    
    // for phicys and stuff
    public Rigidbody2D rb;
    
    //Place to store movement it hasw nothing to do with dirtion i just called it that becasue
    private Vector2 moveDirtion;

    
 



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        inputManger(); // runs inputmanger look below for the inputmanger code
    }
    
    
    
    
    private void FixedUpdate() // FixedUpdate is better for phiclys stuff like movemnet
    {
        Move();
    }

    void inputManger()
    {
        float moveX = Input.GetAxisRaw("Horizontal"); //gets the X input
        float moveY = Input.GetAxisRaw("Vertical"); //gets the Y input
        moveDirtion = new Vector2(moveX, moveY).normalized; // gives moveDirtion teh power to be called for movement again it has nothing to do with dirtion it just stores where we  want our player to go. .noremalized makes the dignles the same speed as the others 
    
    }

    void Move()
    {
        rb.velocity = new Vector2(moveDirtion.x * movespeed, moveDirtion.y * movespeed); //Changes the RB loction in scean to move. moveDirtion.x is kind of like a if statment and then we times that by move speed for the speed 
    }
}
