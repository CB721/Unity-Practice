using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TipCalculator : MonoBehaviour
{
    // bill
    public float bill;
    // tip percentage
    public float tipPercent = 20.0f;
    // calculate total amount
    public float total;
    void Start()
    {
        // calculate the tip amount
        float tip = bill * (tipPercent / 100);
        // calculate the total
        total = bill + tip;
        // convert to decimal with two places and print values
        Debug.Log($"Your bill is ${Mathf.Round(bill * 100f) / 100f}.");
        Debug.Log($"Your tip is ${Mathf.Round(tip * 100f) / 100f}.");
        Debug.Log($"Your total is ${Mathf.Round(total * 100f) / 100f}.");
    }
}
