using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOverScreen : MonoBehaviour
{
    public static bool gameIsOver = false;
    public TextMeshProUGUI gameOverTextUI;
    public GameObject gameOverUI;

    void Start()
    {
        gameIsOver = false;
    }
    public void Setup(string gameOverText)
    {
        Time.timeScale = 0f;
        gameOverUI.SetActive(true);
        gameOverTextUI.text = gameOverText;
        gameIsOver = true;
    }
    
    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }
    
}
