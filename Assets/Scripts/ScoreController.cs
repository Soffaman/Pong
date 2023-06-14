using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ScoreController : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI score1;
    [SerializeField]
    TextMeshProUGUI score2;

    private int player1Score = 0;
    private int player2Score = 0;

    public int goalsToWin = 7;

    private void Update()
    {
        if(this.player1Score >= this.goalsToWin || this.player2Score >= this.goalsToWin)
        {
            Debug.Log("Game Won");
            SceneManager.LoadScene("GameOver");
        }
    }

    private void FixedUpdate()
    {
        score1.text = player1Score.ToString();
        score2.text = player2Score.ToString();
    }

    public void IncresePlayer1()
    {
        player1Score++;
    }

    public void IncresePlayer2()
    {
        player2Score++;
    }
    
}
