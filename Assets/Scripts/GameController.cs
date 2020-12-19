using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    // Script que controla o game
    public int Score;
    public int CoinScore;
    public Text scoreText;
    public Text coinText;
    public float ScorePerSecond;
    public static GameController current;
    public bool PlayerIsAlive;
    public GameObject GameOverPanel;
    public Button RestartBtn;

    void Start()
    {
        current = this;
        PlayerIsAlive = true;
    }

    float ScoreUpdated;
    void Update()
    {
        if(PlayerIsAlive) {
            ScoreUpdated += ScorePerSecond * Time.deltaTime;
            Score = (int)ScoreUpdated;

            // Atualizando o texto da interface
            scoreText.text = Score.ToString("0000");
        }  
    }

    public void AddScore(int value) {
        CoinScore += value;
        coinText.text = CoinScore.ToString("0000");
    }

    public void RestartGame() {
        SceneManager.LoadScene(0);
    }
}
