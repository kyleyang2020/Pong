using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMove : MonoBehaviour
{
    public float speed = .1f;
    private float yBorder = 4.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // press up to move the paddle up
        if(Input.GetKey(KeyCode.UpArrow))
            transform.position = new Vector2(transform.position.x, transform.position.y + speed);

        // press down to move the paddle down
        if (Input.GetKey(KeyCode.DownArrow))
            transform.position = new Vector2(transform.position.x, transform.position.y - speed);
    }
}
