using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class GameOverMenu : MonoBehaviour {

    [SerializeField]
    TMP_Text textScore;

    Money money;

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
    }

    private void Update()
    {
        textScore.text = "Your Score: " + money.money; 

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
