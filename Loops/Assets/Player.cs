using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // create a program that prints out 0 - 10 and then prints out only even numbers to 20 and then only odd numbers to 30

    void Start()
    {
        for (int i = 0; i < 30; i++)
        {
            if (i <= 10)
            {
                Debug.Log(i);
            }
            else if (i > 10 && i <= 20 && i % 2 == 0)
            {
                Debug.Log(i);
            }
            else if (i > 20 && i <= 30 && i % 2 == 1)
            {
                Debug.Log(i);
            }
        }
    }

}
