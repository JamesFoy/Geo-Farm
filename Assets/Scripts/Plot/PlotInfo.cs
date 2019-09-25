using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlotInfo : MonoBehaviour
{
    //
    [SerializeField]
    Image image;
    public Color color;
    //

    [SerializeField]
    private TMP_Text uiText;

    public string cropName = "null";
    public float timer;
    public float growthTime;
    public int purchasePrice;
    public int sellingPrice;
    public enum BehaviourStates { nocrop, planted, growing1, growing2, completegrown };
    public BehaviourStates cropState;

    void OnAwake()
    {
        //sets crop to no crop
        cropState = BehaviourStates.nocrop;
    }

    private void Start()
    {
        uiText.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        //updates plot colour to the colour of the crop or dirt
        image.color = color;

        //if a crop is planted
        if (cropState == BehaviourStates.planted)
        {
            //timer is displayed
            uiText.enabled = true;

            //crop timer starts
            if (timer >= 0)
            {
                timer -= Time.deltaTime;
                uiText.text = timer.ToString("F");
            }

            //if crop timer is 0
            else if (timer <= 0)
            {
                //the crop is finished
                cropState = BehaviourStates.completegrown;

                //if the crop is finished
                if (cropState == BehaviourStates.completegrown)
                {
                    //stop timer and remove text
                    timer = 0.0f;
                    uiText.enabled = false;
                    //display tick/sound effect

                }
            }
        }
    }
}
