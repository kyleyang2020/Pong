using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallScore : MonoBehaviour
{
    int playerOneScore, playerTwoScore; // variable for score
    // text components for score
    [SerializeField] private Text scoreP1;
    [SerializeField] private Text scoreP2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // every frame updates the score 
        scoreP1.text = playerOneScore.ToString();
        scoreP2.text = playerTwoScore.ToString();
    }

    private void OnCollisionEnter2D(Collision2D collision) 
    {
        // when ball hits left/right goal updates the scores
        if (collision.collider.CompareTag("LeftGoal"))
            playerTwoScore++;
        if (collision.collider.CompareTag("RightGoal"))
            playerOneScore++;
    }
}
