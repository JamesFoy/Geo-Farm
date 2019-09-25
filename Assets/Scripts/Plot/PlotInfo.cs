﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlotInfo : MonoBehaviour
{
    //
    [SerializeField]
    Image image;
    public Color color;
    //

    [SerializeField]
    private TMP_Text uiText;

    public string cropName = "null";
    public float timer;
    public float growthTime;
    public int purchasePrice;
    public int sellingPrice;
    public enum BehaviourStates { nocrop, planted, growing1, growing2, completegrown };
    public BehaviourStates cropState;

    void OnAwake()
    {
        cropState = BehaviourStates.nocrop;
    }

    private void Start()
    {
        uiText.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        image.color = color;

        if (cropState == BehaviourStates.planted)
        {
            uiText.enabled = true;

            if (timer >= 0)
            {
                timer -= Time.deltaTime;
                uiText.text = timer.ToString("F");
            }

            else if (timer <= 0)
            {
                cropState = BehaviourStates.completegrown;
                if (cropState == BehaviourStates.completegrown)
                {
                    timer = 0.0f;
                    uiText.enabled = false;
                    //display tick/sound effect
                }
            }
        }
    }
}
