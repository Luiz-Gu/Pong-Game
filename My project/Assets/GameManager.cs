using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using static UnityEngine.Rendering.VirtualTexturing.Debugging;

public class GameManager : MonoBehaviour

{
    [Header("ball")]
    public GameObject ball;

    [Header("Player 1")]
    public GameObject Player1Paddle;
    public GameObject Player1Goal;


    [Header("Player 2")]
    public GameObject Player2Paddle;
    public GameObject Player2Goal;

    [Header("Score UI")]
    public GameObject Player1text;
    public GameObject Player2text;


    private int Player1score;
    private int Player2score;

    public void Player1Scored()
    {
        Player1score++;
        Player1text.GetComponent<TextMeshProUGUI>().text = Player1score.ToString();
        ResetPosition();

       

    }
    public void Player2Scored()
    {
        Player2score++;
        Player2text.GetComponent<TextMeshProUGUI>().text = Player2score.ToString();
        ResetPosition();
    }
    // Start is called before the first frame update

    private void ResetPosition()
    {
        ball.GetComponent<BallMovement>().Reset();
        Player1Paddle.GetComponent<Player>().Reset();
        Player2Paddle.GetComponent<Player>().Reset();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
