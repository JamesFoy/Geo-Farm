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
    public Color cacheColor;
    //

    public Image finishedIcon;
    public Image sellingIcon;
    public Image purchaseIcon;

    private Animator anim;

    [SerializeField]
    private TMP_Text uiText;

    public enum CropChoice {non, carrot, raddish, corn, potato, tomato, wheet}
    public CropChoice cropChoice;

    public string cropName = "null";
    public float timer;
    public float growthTime;
    public int purchasePrice;
    public int sellingPrice;
    public enum BehaviourStates { nocrop, planted, water, completegrown };
    public BehaviourStates cropState;

    public AudioSource sellSound;

    public AudioSource buySound;

    public float randomTime;
    private float nextWater;

    public bool waterMe;

    void OnAwake()
    {
        //sets crop to no crop
        cropState = BehaviourStates.nocrop;
    }

    private void Start()
    {
        finishedIcon.enabled = false;
        sellingIcon.enabled = false;
        purchaseIcon.enabled = false;
        anim = GetComponent<Animator>();
        cacheColor = image.color;
        uiText.enabled = false;
        cropChoice = CropChoice.non;
    }

    // Update is called once per frame
    void Update()
    {
        if (cropChoice == CropChoice.non)
        {
            anim.SetBool("carrot", false);
            anim.SetBool("raddish", false);
            anim.SetBool("potato", false);
            anim.SetBool("corn", false);
            anim.SetBool("wheet", false);
            anim.SetBool("tomato", false);
            finishedIcon.enabled = false;
            purchaseIcon.enabled = false;
        }
        else if (cropChoice == CropChoice.carrot)
        {
            anim.SetBool("carrot", true);
        }
        else if (cropChoice == CropChoice.raddish)
        {
            anim.SetBool("raddish", true);
        }
        else if (cropChoice == CropChoice.potato)
        {
            anim.SetBool("potato", true);
        }
        else if (cropChoice == CropChoice.corn)
        {
            anim.SetBool("corn", true);
        }
        else if (cropChoice == CropChoice.wheet)
        {
            anim.SetBool("wheet", true);
        }
        else if (cropChoice == CropChoice.tomato)
        {
            anim.SetBool("tomato", true);
        }


        //updates plot colour to the colour of the crop or dirt
        image.color = color;

        //if a crop is planted
        if (cropState == BehaviourStates.planted)
        {
            uiText.text = timer.ToString("F");
            waterMe = false;

            //timer is displayed
            uiText.enabled = true;

            //crop timer starts
            if (timer >= 0.0f)
            {
                timer -= Time.deltaTime;
            }

            else if (cropState == BehaviourStates.water)
            {
                //display water me icon
                waterMe = true;
            }

            //if crop timer is 0
            else if (timer <= 0.0f)
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
                    finishedIcon.enabled = true;
                }
            }
        }
    }

    public IEnumerator WaterTime()
    {
        yield return new WaitForSecondsRealtime(growthTime/2);
        cropState = BehaviourStates.water;
    }
}
