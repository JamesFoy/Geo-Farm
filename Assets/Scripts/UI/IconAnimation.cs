using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IconAnimation : MonoBehaviour
{
    Animator anim;
    PlotInfo plotInfo;
    PlotInteraction plotInteraction;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        plotInfo = GetComponentInParent<PlotInfo>();
        plotInteraction = GetComponentInParent<PlotInteraction>();
    }

    // Update is called once per frame
    void Update()
    {
        if (plotInfo.cropState == PlotInfo.BehaviourStates.planted)
        {
            if (!anim.GetBool("Purchase"))
            {
                anim.SetBool("Purchase", true);
            }
            plotInfo.purchaseIcon.enabled = true;

            if (anim.GetBool("Sell"))
            {
                anim.SetBool("Sell", false);
            }
            plotInfo.sellingIcon.enabled = false;
        }

        else if (plotInfo.cropState == PlotInfo.BehaviourStates.completegrown)
        {
            if (!anim.GetBool("Finished"))
            {
                anim.SetBool("Finished", true);
            }

            if (anim.GetBool("Purchase"))
            {
                anim.SetBool("Purchase", false);
            }
            plotInfo.purchaseIcon.enabled = false;
        }

        if (plotInfo.cropState != PlotInfo.BehaviourStates.completegrown)
        {
            anim.SetBool("Finished", false);
        }

        if (plotInfo.cropState == PlotInfo.BehaviourStates.nocrop)
        {
            if (!anim.GetBool("Sell"))
            {
                anim.SetBool("Sell", true);
            }
        }
    }
}
