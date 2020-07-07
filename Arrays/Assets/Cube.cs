using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    // on space, change all of the cubes to a random color
    private string[] colors = new string[] { "yellow", "red", "green", "blue" };
    public GameObject[] cubes;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            foreach (var cube in cubes)
            {
                string randomColor = colors[Random.Range(0, colors.Length)];
                switch (randomColor)
                {
                    case "yellow":
                        cube.GetComponent<MeshRenderer>().material.color = Color.yellow;
                        break;
                    case "red":
                        cube.GetComponent<MeshRenderer>().material.color = Color.red;
                        break;
                    case "green":
                        cube.GetComponent<MeshRenderer>().material.color = Color.green;
                        break;
                    case "blue":
                        cube.GetComponent<MeshRenderer>().material.color = Color.blue;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
