using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // private bool isGameOver;
    // public bool IsGameOver
    // {
    //     get
    //     {
    //         return isGameOver;
    //     }
    //     set
    //     {
    //         if (value)
    //         {
    //             Debug.Log("The game is over");
    //         }
    //         else 
    //         {
    //             Debug.Log("The game is still going");
    //         }
    //         isGameOver = value;
    //     }
    // }

    public bool IsGameOver { get; private set; }
    void Start()
    {
        // isGameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        // if (Input.GetKeyDown(KeyCode.Space))
        // {
        //     IsGameOver = true;
        // }
        // if (Input.GetKeyDown(KeyCode.G))
        // {
        //     IsGameOver = false;
        // }
    }
}
