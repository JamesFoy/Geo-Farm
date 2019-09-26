using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class MainMenu : MonoBehaviour {

    public string playFarmingSim; //Accesses the Farming Sim scene

	public void PlayGame() //Starts the game by opening the Farming Sim scene
    {
        SceneManager.LoadScene(playFarmingSim); //Loads the scene known as Farming Sim
    }

    public void QuitGame() //Closes the game to desktop 
    {
        Application.Quit(); //The game stops running and closes
    }
}
