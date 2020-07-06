using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    // every item has
    // a name
    public string name;
    // a description
    public string description;
    // an image icon
    public Sprite icon;
    // an attack strength
    public float attack;
    
    void Start()
    {
        Debug.Log(name);   
        Debug.Log(description);   
        Debug.Log(icon);   
        Debug.Log(attack);   
    }

}
