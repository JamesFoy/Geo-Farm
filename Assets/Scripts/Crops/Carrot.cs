using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carrot : Crops
{
    public override void SetAttributes()
    {
        cropName = "Carrot";
        growthTime = 10f;
        purchasePrice = 5;
        sellingPrice = 10;
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

            plotInfo.cropChoice = PlotInfo.CropChoice.carrot;

            plotInfo.buySound.Play();

            purchaseEvent.Raise();
        }
    }
}
