using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private int playerScore;
    private int enemyScore;
    public Ball ball;
    public PlayerPaddle playerPaddle;
    public EnemyPaddle enemyPaddle;
    public TMPro.TMP_Text playerScoreText;
    public TMPro.TMP_Text enemyScoreText;

    private void Awake()
    {
        ball = GameObject.Find("Ball").GetComponent<Ball>();
        playerPaddle = GameObject.Find("Player Bar").GetComponent<PlayerPaddle>();
        enemyPaddle = GameObject.Find("Enemy Bar").GetComponent<EnemyPaddle>();
    }

    public void PlayeScore()
    {
        playerScore++;
        playerScoreText.text = playerScore.ToString();
        NewRound();
    }
    public void EnemyScore()
    {
        enemyScore++;
        enemyScoreText.text = enemyScore.ToString();
        NewRound();
    }

    public void ResetGame()
    {
        NewRound();
    }
    
    public void ResetGameobjects() 
    {
        ball.ResetBall();
        ball.AddForceOnStart();
        playerPaddle.ReestPaddle(Vector3.zero, new Vector3(-7.5f, 0f, 0f));
        enemyPaddle.ReestPaddle(Vector3.zero, new Vector3(7.5f, 0f, 0f));
    }

    public void NewRound()
    {
        ResetGameobjects();
    }


}
