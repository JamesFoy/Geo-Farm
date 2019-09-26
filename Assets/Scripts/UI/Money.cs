using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Money : MonoBehaviour
{
    [SerializeField]
    private TMP_Text uiText;

    public int money;

    // Update is called once per frame
    void Update()
    {
        uiText.text = "$ " + money;
    }
}
