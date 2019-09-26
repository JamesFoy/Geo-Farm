using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{
    public void RestartGame() //Restarts the current scene
    {
        SceneManager.LoadScene("Farming Sim");
    }
}
