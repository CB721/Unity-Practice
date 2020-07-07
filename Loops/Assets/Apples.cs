using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apples : MonoBehaviour
{
    private int _apples;
    private void Start() 
    {
        StartCoroutine(AddApplesRoutine());
    }

    IEnumerator AddApplesRoutine()
    {
        for (int i = 0; i < 100; i++)
        {
            Debug.Log($"There are {_apples} apples");
            _apples++;
            yield return new WaitForSeconds(1.0f);
        }
    }
}
