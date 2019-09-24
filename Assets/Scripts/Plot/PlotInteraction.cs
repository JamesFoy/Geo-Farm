using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlotInteraction : MonoBehaviour
{
    [SerializeField]
    GameObject SelectWheel;

    void OnMouseEnter()
    {
        //Highlight/change image
        Debug.Log("Mouse Entered Plot");
    }

    public void OnButtonClick()
    {
        SelectWheel.SetActive(false);
    }

    private void OnMouseDown()
    {
        SelectWheel.SetActive(true);
    }
}
