using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tomato : Crops
{
    public override void SetAttributes()
    {
        cropName = "Tomato";
        growthTime = 25f;
        purchasePrice = 1;
        sellingPrice = 5;
    }

    public override void OnSelection()
    {
        if (money.money >= purchasePrice)
        {
            plotInfo.color = color;

            plotInfo.timer = growthTime;

            plotInfo.cropName = cropName;
            plotInfo.growthTime = growthTime;
            plotInfo.purchasePrice = purchasePrice;
            plotInfo.sellingPrice = sellingPrice;

            plotInfo.cropState = PlotInfo.BehaviourStates.planted;

            money.money -= purchasePrice;

            plotInfo.cropChoice = PlotInfo.CropChoice.tomato;

            plotInfo.buySound.Play();

            purchaseEvent.Raise();
        }
    }
}
