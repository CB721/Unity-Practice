using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    // create a program where you assign a cube in the inspector
    // when you hit the space bar, pass that cube into a function that will change its color to a random color
    public GameObject cube;
    private void Start()
    {
        cube.GetComponent<Renderer>().material.color = Color.red;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ChangeColor(cube);
        }
    }
    private void ChangeColor(GameObject selectedCube)
    {
        string[] colors = new string[] { "red", "orange", "yellow", "green", "blue", "purple" };
        string cubeColor = colors[Random.Range(0, colors.Length)];
        switch (cubeColor)
        {
            case "red":
                selectedCube.GetComponent<Renderer>().material.color = new Color32(212, 29, 29, 255);
                break;
            case "orange":
                selectedCube.GetComponent<Renderer>().material.color = new Color32(243, 117, 17, 255);
                break;
            case "yellow":
                selectedCube.GetComponent<Renderer>().material.color = new Color32(243, 222, 17, 255);
                break;
            case "green":
                selectedCube.GetComponent<Renderer>().material.color = new Color32(31, 212, 19, 255);
                break;
            case "blue":
                selectedCube.GetComponent<Renderer>().material.color = new Color32(19, 64, 212, 255);
                break;
            case "purple":
                selectedCube.GetComponent<Renderer>().material.color = new Color32(62, 7, 104, 255);
                break;
            default:
                break;
        }
    }
}
