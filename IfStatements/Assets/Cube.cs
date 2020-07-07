using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    // when the space key is hit
    // the score value is incremented
    // when the score is greater than 50
    // turn the cube green
    // at the start of the program, turn the cube red
    // Start is called before the first frame update

    public GameObject cube;
    private int score;
    
    void Start()
    {
        cube.GetComponent<Renderer>().material.color = Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        if (score > 50)
        {
            cube.GetComponent<Renderer>().material.color = Color.green;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            score++;
        }
    }
}
