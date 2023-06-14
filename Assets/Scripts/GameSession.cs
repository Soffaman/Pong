using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameSession : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI score1;
    [SerializeField]
    TextMeshProUGUI score2;

    int player1Score = 0;
    int player2Score = 0;

    private void Awake()
    {
        int numGameSession = FindObjectsOfType<GameSession>().Length;
        if (numGameSession > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    private void Start()
    {
        score1.text = player1Score.ToString();
        score2.text = player2Score.ToString();
    }

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

    public void ReloadScene()
    {
        Invoke("Restart", 1f);
    }

    private void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
