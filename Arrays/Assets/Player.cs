using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // select a random age and random name
    // print these values
    public int[] ages;
    public string[] names;
    // Start is called before the first frame update
    void Start()
    {
        int randomAge = ages[Random.Range(0, ages.Length)];
        string randomName = names[Random.Range(0, names.Length)];
        Debug.Log(randomAge);
        Debug.Log(randomName);
    }

    // Update is called once per frame
    void Update()
    {
        // print out all of the names using a foreach loop
        if (Input.GetKeyDown(KeyCode.Space))
        {
            foreach(var name in names)
            {
                Debug.Log(name);
            }
        }
    }
}
