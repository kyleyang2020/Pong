using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallMovement : MonoBehaviour
{
    // variable for speed
    [SerializeField] private float xSpeed;
    [SerializeField] private float ySpeed;

    // variable for borders
    [SerializeField] private float xBorder;
    [SerializeField] private float yBorder;

    // variable for move state
    private bool xMove = true;
    private bool yMove = true;

    // variable for score
    int playerOneScore;
    int playerTwoScore;
    [SerializeField] private Text scoreP1;
    [SerializeField] private Text scoreP2;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // horizontal movement
        if (xMove)
            transform.position = new Vector2(transform.position.x + xSpeed, transform.position.y); // right
        else
            transform.position = new Vector2(transform.position.x - xSpeed, transform.position.y); // left

        // vertical movement
        if (yMove)
            transform.position = new Vector2(transform.position.x, transform.position.y + ySpeed); // up
        else
            transform.position = new Vector2(transform.position.x, transform.position.y - ySpeed); // down

        // checks if ball hits left and give player2 score and bounces ball back
        if (transform.position.x >= xBorder)
        {
            xMove = false;
            playerTwoScore++;
        }

        // checks if ball hits right and give player1 score and bounces ball back
        if (transform.position.x <= -xBorder)
        {
            xMove = true;
            playerOneScore++;
        }

        // checks if ball hits top or bottom borders and bounces back
        if (transform.position.y >= yBorder)
            yMove = false;

        if (transform.position.y <= -yBorder)
            yMove = true;

        scoreP1.text = playerOneScore.ToString();
        scoreP2.text = playerTwoScore.ToString();
    }

    // when collision happens if it hits a paddle/player bounce back
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("hit");
        if(collision.collider.CompareTag("Player"))
        {
            if (xMove)
                xMove = false;
            else
                xMove = true;
        }
    }
}
