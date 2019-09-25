﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cabbage : Crops
{
    public override void SetAttributes()
    {
        cropName = "Cabbage";
        growthTime = 30;
        purchasePrice = 10;
        sellingPrice = 50;
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
