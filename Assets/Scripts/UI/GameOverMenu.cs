using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class GameOverMenu : MonoBehaviour {

    private bool scoreUpdated;

    [SerializeField]
    TMP_Text textScore;

    [SerializeField]
    TMP_Text highTextScore;

    Money money;
    private int highScore;

    public string mainMenuLevel; //Allows the script to access the Main Menu scene

    public enum GameStates {pause, play }
    public GameStates gameStates;

    [SerializeField]
    GameObject gameOverCanvas;

    [SerializeField]
    UICountdown countdown;

    private void Start()
    {
        money = FindObjectOfType<Money>();
        countdown = FindObjectOfType<UICountdown>();
        gameStates = GameStates.play;

        if (PlayerPrefs.HasKey("HighScore"))
        {
            highScore = PlayerPrefs.GetInt("HighScore");
        }

        scoreUpdated = false;
    }

    void SaveScore()
    {
        if (money.money > highScore)
        {
            PlayerPrefs.SetInt("HighScore", money.money);
        }

        PlayerPrefs.Save();
    }

    void DeleteKey()
    {
        PlayerPrefs.DeleteKey("HighScore");
    }

    private void Update()
    {
        if (!scoreUpdated && countdown.timer <= 0)
        {
            SaveScore();
            Debug.Log("High Score Updated");
            scoreUpdated = true;
        }

        textScore.text = "Your Score: " + money.money;
        highTextScore.text = "High Score: " + PlayerPrefs.GetInt("HighScore");

        if (gameStates == GameStates.play)
        {
            gameOverCanvas.SetActive(false);
        }

        else if (gameStates == GameStates.pause)
        {
            gameOverCanvas.SetActive(true);
        }
    }

    public void QuitToMain() //Loads the Main Menu scene
    {
        SceneManager.LoadScene(mainMenuLevel); //Loads the scene known as Main Menu
    }

}
