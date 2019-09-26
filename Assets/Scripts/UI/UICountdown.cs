﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UICountdown : MonoBehaviour
{
    [SerializeField]
    private TMP_Text uiText;

    [SerializeField]
    private float mainTimer;

    GameOverMenu gameOverMenu;

    public float timer;
    private bool canCount = true;
    private bool doOnce = false;

    private void Start()
    {
        gameOverMenu = FindObjectOfType<GameOverMenu>();
        timer = mainTimer;
    }

    private void Update()
    {
        //timer for the game
        if (timer >= 0.0f && canCount)
        {
            timer -= Time.deltaTime;
            uiText.text = timer.ToString("F");
        }

        else if (timer <= 0.0f && !doOnce)
        {
            canCount = false;
            doOnce = true;
            uiText.text = "0.00";
            timer = 0.0f;
            gameOverMenu.gameStates = GameOverMenu.GameStates.pause;
        }
    }
}
