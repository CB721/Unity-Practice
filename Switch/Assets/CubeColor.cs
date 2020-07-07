using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeColor : MonoBehaviour
{
    public GameObject cube;

    // create a program that turns the cube a different color based on user input
    // 1 key = blue
    // 2 key = red
    // 3 key = green
    // 4 key = black
    void Update()
    {
        string _keyPressed = Input.inputString;
        switch (_keyPressed)
        {
            case "1":
                cube.GetComponent<Renderer>().material.color = Color.blue;
                break;
            case "2":
                cube.GetComponent<Renderer>().material.color = Color.red;
                break;
            case "3":
                cube.GetComponent<Renderer>().material.color = Color.green;
                break;
            case "4":
                cube.GetComponent<Renderer>().material.color = Color.black;
                break;
            default:
                break;
        }
    }
}
