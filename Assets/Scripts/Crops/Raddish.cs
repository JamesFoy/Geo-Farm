using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raddish : Crops
{
    public override void SetAttributes()
    {
        cropName = "Raddish";
        growthTime = 30;
        purchasePrice = 10;
        sellingPrice = 50;
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

            plotInfo.cropChoice = PlotInfo.CropChoice.raddish;

            plotInfo.buySound.Play();

            purchaseEvent.Raise();
        }
    }
}
