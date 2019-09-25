using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tomato : Crops
{
    public override void SetAttributes()
    {
        cropName = "Tomato";
        growthTime = 5f;
        purchasePrice = 1;
        sellingPrice = 5;
    }

    public void OnSelection()
    {
        plotInfo.color = color;

        plotInfo.timer = growthTime;

        plotInfo.cropName = cropName;
        plotInfo.growthTime = growthTime;
        plotInfo.purchasePrice = purchasePrice;
        plotInfo.sellingPrice = sellingPrice;

        plotInfo.cropState = PlotInfo.BehaviourStates.planted;
    }
}
