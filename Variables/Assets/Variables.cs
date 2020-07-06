using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
    // create the variables below and print them to the console
    // your name
    public string myName = "Clint";
    // your age
    public int myAge = 27;
    // your speed
    public float speed = 24.5f;
    // your health
    public int health = 75;
    // your score
    public int score = 23;
    // to check if you have collected all keys
    public bool hasAllKeys = false;
    // your ammo count
    public byte ammoCount = 128;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log($"Hi, my name is {myName}.");
        Debug.Log($"I am {myAge} years old.");
        Debug.Log($"I have a speed of {speed} MPH.");
        Debug.Log($"I have {health}HP remaining.");
        Debug.Log($"My current score is {score}");
        if (hasAllKeys)
        {
            Debug.Log("All keys have been collected.");
        }
        else
        {
            Debug.Log("There are still keys to be collected.");
        }
        Debug.Log($"I have {ammoCount} ammo left.");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
