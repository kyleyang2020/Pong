using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMove : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rigidBody; // accesses the paddle rigidbody component
    [SerializeField] private float speed; // speed of the paddle movement
    [SerializeField] private bool isPlayer1; // check which paddle is which for 2 player controls
    private float movement; // # from (-1,1) which dictates the direction of paddle

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // checks which player is playing and gives different inputs for each player
        if(isPlayer1)
        {
            // accesses Unity input manager has inputs w and s
            movement = Input.GetAxisRaw("Vertical");
        }
        else
        {
            // accesses Unity input manager has inputs down and up arrow
            movement = Input.GetAxisRaw("Vertical2");
        }

        // uses the RigidBody2D component to change velocity up and down based off input
        rigidBody.velocity = new Vector2(rigidBody.velocity.x, movement * speed);
    }
}
