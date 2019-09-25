using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crops : MonoBehaviour
{
    protected GameObject plot;
    protected PlotInfo plotInfo;
    protected string cropName;
    protected float growthTime;
    protected int purchasePrice;
    protected int sellingPrice;

    // Start is called before the first frame update
    void Start()
    {
        SetAttributes();
        plotInfo = gameObject.GetComponentInParent<PlotInfo>();
        plot = gameObject.GetComponentInParent<PlotInteraction>().gameObject;
    }

    public virtual void SetAttributes()
    {
        //this is used to set each different crops attributes
    }
}
