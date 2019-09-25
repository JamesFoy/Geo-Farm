using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Crops : MonoBehaviour
{
    //This is used for prototype purpose
    Image image;
    protected Color color;
    //

    protected Money money;

    protected GameObject plot;
    protected PlotInfo plotInfo;
    protected string cropName;
    protected float growthTime;
    protected int purchasePrice;
    protected int sellingPrice;

    // Start is called before the first frame update
    void Start()
    {
        money = FindObjectOfType<Money>();

        //
        image = this.gameObject.GetComponent<Image>();
        color = image.color;
        //

        SetAttributes();
        plotInfo = gameObject.GetComponentInParent<PlotInfo>();
        plot = gameObject.GetComponentInParent<PlotInteraction>().gameObject;
    }

    public virtual void SetAttributes()
    {
        //this is used to set each different crops attributes
    }
}
