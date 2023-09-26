using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMove : MonoBehaviour
{
    [SerializeField] private float speed; // speed of the paddle movement
    [SerializeField] private bool isPlayer1; // check which paddle is which for 2 player controls

    private Rigidbody2D _rigidBody; // calls the paddle rigidbody component
    private float movement; // # from (-1,1) which dictates the direction of paddle

    private void Awake()
    {
        // grabs rigidbody component when script is loaded
        _rigidBody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // checks which player is playing and gives different inputs for each player
        if(isPlayer1)
            // accesses Unity input manager has inputs w and s
            movement = Input.GetAxisRaw("Vertical");
        else
            // accesses Unity input manager has inputs down and up arrow
            movement = Input.GetAxisRaw("Vertical2");

        // uses the RigidBody2D component to change velocity up and down based off input
        _rigidBody.velocity = new Vector2(0, movement * speed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // if the paddle hits the walls, dont go past it
        if (isPlayer1)
            movement = 0;
        else
            movement = 0;
    }
}
