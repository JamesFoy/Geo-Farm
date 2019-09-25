using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlotInfo : MonoBehaviour
{
    public string cropName = "null";
    public float timer;
    public float growthTime;
    public int purchasePrice;
    public int sellingPrice;
    public enum BehaviourStates { nocrop, planted, growing1, growing2, completegrown };
    public BehaviourStates cropState;

    void OnAwake()
    {
        cropState = BehaviourStates.nocrop;
    }

    // Update is called once per frame
    void Update()
    {
        if (cropState == BehaviourStates.planted)
        {
            timer = growthTime;

            if (timer >= 0)
            {
                timer -= Time.deltaTime;
            }

            else if (timer <= 0)
            {
                timer = 0.0f;
                Debug.Log("Growth Complete");
                //display tick/sound effect
            }
        }
    }
}
