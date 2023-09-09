using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    // variable for speed
    public float xSpeed = 0;
    public float ySpeed = 0;

    // variable for borders
    private float xBorder = 7.5f;
    private float yBorder = 4.5f;


    // Start is called before the first frame update
    void Start()
    {
        xSpeed = .1f;
        ySpeed = .1f;
    }

    // Update is called once per frame
    void Update()
    {
        // horizontal movement
        transform.position = new Vector2(transform.position.x + xSpeed, transform.position.y);

        // checks if ball hits left or right borders and bounces back
        if(transform.position.x >= xBorder)
            xSpeed *= -1;

        if(transform.position.x <= -xBorder)
            xSpeed *= -1;

        // vertial movement
        transform.position = new Vector2(transform.position.x, transform.position.y + ySpeed);

        // checks if ball hits top or bottom borders and bounces back
        if(transform.position.y >= yBorder)
            ySpeed *= -1;

        if(transform.position.y <= -yBorder)
            ySpeed *= -1;
    }
}
