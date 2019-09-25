using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlotInteraction : MonoBehaviour
{
    [SerializeField]
    GameObject SelectWheel;

    Money money;

    PlotInfo plotInfo;

    public enum Behaviours {NotInUse, BeingUsed, Purchaseable}
    public Behaviours plotState;

    private void Start()
    {
        money = FindObjectOfType<Money>();
        plotInfo = GetComponent<PlotInfo>();
        plotState = Behaviours.NotInUse;
    }

    public void OnButtonClick()
    {
        //when you click an option (works even if you cant purcahse the selection)
        SelectWheel.SetActive(false);
    }

    private void OnMouseDown()
    {
        //if the plot of land isnt in use
        if (plotState == Behaviours.NotInUse)
        {
            //display crop selection pop up
            SelectWheel.SetActive(true);
        }

        //if the crop is finished growing
        if (plotInfo.cropState == PlotInfo.BehaviourStates.completegrown)
        {
            //sell crop
            money.money += plotInfo.sellingPrice;

            //Display selection wheel
            SelectWheel.SetActive(true);
            plotState = Behaviours.NotInUse;
        }
    }

    private void Update()
    {
        //if a crop has been put in a plot
        if (plotInfo.cropState != PlotInfo.BehaviourStates.nocrop)
        {
            //the plot is being used
            plotState = Behaviours.BeingUsed;
        }
    }
}
