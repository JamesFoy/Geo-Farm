using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlotInteraction : MonoBehaviour
{
    [SerializeField]
    GameObject SelectWheel;

    IconAnimation iconAnimation;
    Money money;

    GameOverMenu gameOverMenu;
    PlotInfo plotInfo;

    public enum Behaviours {NotInUse, BeingUsed, Purchaseable}
    public Behaviours plotState;

    private void Start()
    {
        iconAnimation = GetComponentInChildren<IconAnimation>();
        gameOverMenu = FindObjectOfType<GameOverMenu>();
        money = FindObjectOfType<Money>();
        plotInfo = GetComponent<PlotInfo>();
        plotState = Behaviours.NotInUse;
    }

    public void OnButtonClick()
    {
        //when you click an option (works even if you cant purcahse the selection)
        SelectWheel.SetActive(false);
    }

    private void OnMouseDown()
    {
        if (gameOverMenu.gameStates != GameOverMenu.GameStates.pause)
        {
            //if the plot of land isnt in use
            if (plotState == Behaviours.NotInUse)
            {
                //display crop selection pop up
                SelectWheel.SetActive(true);
            }

            if (plotInfo.cropState == PlotInfo.BehaviourStates.water)
            {
                plotInfo.waterMe = false;
                plotInfo.cropState = PlotInfo.BehaviourStates.planted;
                StopCoroutine(plotInfo.WaterTime());
            }

            //if the crop is finished growing
            if (plotInfo.cropState == PlotInfo.BehaviourStates.completegrown)
            {
                //sell crop
                money.money += plotInfo.sellingPrice;
                plotInfo.sellSound.Play();

                //Reset Method
                Reset();

                //Display selection wheel
                SelectWheel.SetActive(true);

            }
        }
    }

    private void Reset()
    {
        plotState = Behaviours.NotInUse;
        plotInfo.cropState = PlotInfo.BehaviourStates.nocrop;
        plotInfo.cropChoice = PlotInfo.CropChoice.non;
        plotInfo.cropName = "null";
        plotInfo.timer = 0;
        plotInfo.growthTime = 0;
        plotInfo.purchasePrice = 0;
        plotInfo.sellingPrice = 0;
        plotInfo.color = plotInfo.cacheColor;
        plotInfo.sellingIcon.enabled = true;
    }

    private void Update()
    {
        //if a crop has been put in a plot
        if (plotInfo.cropState != PlotInfo.BehaviourStates.nocrop)
        {
            //the plot is being used
            plotState = Behaviours.BeingUsed;
        }
    }
}
