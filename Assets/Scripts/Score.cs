using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI score1;
    [SerializeField]
    TextMeshProUGUI score2;

    int player1Score = 0;
    int player2Score = 0;

    public void IncresePlayer1()
    {
        player1Score++;
        score1.SetText(player1Score.ToString());
        
    }

    public void IncresePlayer2()
    {
        player2Score++;
        score2.text = player2Score.ToString();
    }
    
}
