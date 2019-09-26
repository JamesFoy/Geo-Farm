using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameOverMenu : MonoBehaviour {

    public string mainMenuLevel; //Allows the script to access the Main Menu scene

    public void QuitToMain() //Loads the Main Menu scene
    {
        SceneManager.LoadScene(mainMenuLevel); //Loads the scene known as Main Menu
    }

}
