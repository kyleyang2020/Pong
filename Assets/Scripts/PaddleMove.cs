using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMove : MonoBehaviour
{
    [SerializeField] private float speed = .1f;
    private float yBorder = 4;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // press w to move the paddle up
        // if paddle is at top of screen dont move past it
        if (Input.GetKey(KeyCode.UpArrow) && transform.position.y < yBorder)
            transform.position = new Vector2(transform.position.x, transform.position.y + speed);

        // press s to move the paddle down
        // if paddle is at bottom of screen dont move past it
        if (Input.GetKey(KeyCode.DownArrow) && transform.position.y > -yBorder)
            transform.position = new Vector2(transform.position.x, transform.position.y - speed);
    }
}
