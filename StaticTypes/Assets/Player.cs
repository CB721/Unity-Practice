using System.Collections;
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
    }
}
