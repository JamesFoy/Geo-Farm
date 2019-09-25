using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Corn : Crops
{
    public override void SetAttributes()
    {
        cropName = "Corn";
        growthTime = 5;
        purchasePrice = 2;
        sellingPrice = 4;
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
