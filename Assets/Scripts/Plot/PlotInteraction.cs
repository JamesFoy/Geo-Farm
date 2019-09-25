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

    void OnMouseEnter()
    {
        //Highlight/change image

    }

    public void OnButtonClick()
    {
        SelectWheel.SetActive(false);
    }

    private void OnMouseDown()
    {
        if (plotState == Behaviours.NotInUse)
        {
            SelectWheel.SetActive(true);
        }

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
        if (plotInfo.cropState != PlotInfo.BehaviourStates.nocrop)
        {
            plotState = Behaviours.BeingUsed;
        }
    }
}
