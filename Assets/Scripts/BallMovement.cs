using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    [SerializeField] private float speed; // variable for speed
    private Rigidbody2D _rigidBody; // calls the paddle rigidbody component

    private void Awake()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        BallLaunch();
    }

    private void BallLaunch()
    {
        // x axis random, 50/50 chance to go left (-1) or right (1)
        float x = UnityEngine.Random.value < .5f ? -1f: 1f ;

        // y axis random, 50/50 chance to go at different angle
        // Random.Range give either a neg or pos value for left and right
        float y = UnityEngine.Random.value < .5f ? 
            UnityEngine.Random.Range(-1f, 0f) : UnityEngine.Random.Range(0f, 1f);

        // uses the new values to add the speed towards that direction
        // either one works, different ways/functions

        // _rigidBody.AddForce(new Vector2(x, y) * speed);
        _rigidBody.velocity = new Vector2(x * speed, y * speed);
    }
}
