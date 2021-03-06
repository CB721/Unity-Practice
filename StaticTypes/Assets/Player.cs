﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Utility.CreateGameObject();
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            Utility.SetPositionToZero(this.gameObject);
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            // generate random color
            Color newColor = new Color(Random.value, Random.value, Random.value, 255);
            Utility.ChangeColor(this.gameObject, newColor);
        }
    }
}
