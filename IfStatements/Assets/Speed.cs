using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speed : MonoBehaviour
{
    private int _speed;
    // create a program that does the following
    // increment the speed when the 's' key is pressed
    // decrement the speed when the 'a' key is pressed
    // when the speed is greater than 20, print out 'Slow down!'
    // when the speed is zero, print out 'Speed up!'
    // you cannot go below zero

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            _speed++;
        }
        if (Input.GetKeyDown(KeyCode.A) && _speed > 0)
        {
            _speed--;
        }
        if (_speed > 20)
        {
            Debug.Log("Slow down!");
        }
        else if (_speed == 0)
        {
            Debug.Log("Speed up!");
        }
    }
}
