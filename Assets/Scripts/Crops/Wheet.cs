using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wheet : Crops
{
    public override void SetAttributes()
    {
        cropName = "Wheet";
        growthTime = 15f;
        purchasePrice = 7;
        sellingPrice = 14;
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

            plotInfo.cropChoice = PlotInfo.CropChoice.wheet;

            plotInfo.buySound.Play();
        }
    }
}
