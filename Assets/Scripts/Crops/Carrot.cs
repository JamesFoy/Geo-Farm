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

    public void OnSelection()
    {
        plotInfo.cropName = cropName;
        plotInfo.growthTime = growthTime;
        plotInfo.purchasePrice = purchasePrice;
        plotInfo.sellingPrice = sellingPrice;

        plotInfo.cropState = PlotInfo.BehaviourStates.planted;
    }
}
