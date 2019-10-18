using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Corn : Crops
{
    public override void SetAttributes()
    {
        cropName = "Corn";
        growthTime = 15;
        purchasePrice = 2;
        sellingPrice = 4;
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

            plotInfo.cropChoice = PlotInfo.CropChoice.corn;

            plotInfo.buySound.Play();

            purchaseEvent.Raise();
        }
    }
}
