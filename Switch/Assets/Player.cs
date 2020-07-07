using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int points;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            points = 50;
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            points = 100;
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            points = 0;
        }
        // if points are greater or equal to 50
        // print points to the console
        // if points are 100
        // print points to the console
        // otherwise print 'You need 50 or 100 points to see a message'
        switch (points)
        {
            case 50:
                Debug.Log($"You have {points} points");
                break;
            case 100:
                Debug.Log($"You have {points} points");
                break;
            default:
                Debug.Log("You need 50 or 100 points to see a message");
                break;
        }
    }
}
