using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    // create a program that places the player in a random position at the start
    // they should also move to a new random position whenever space is pressed
    
    void Start()
    {
        transform.position = RandomPos();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.position = RandomPos();
        }
    }
    private Vector3 RandomPos()
    {
        return new Vector3(Random.Range(-10, 10), Random.Range(0, 10), -220);
    }
}
