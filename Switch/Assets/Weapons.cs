using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapons : MonoBehaviour
{
    public int weaponID;
    // ID 1 = gun
    // ID 2 = knife
    // ID 3 = machine gun

    // Update is called once per frame
    void Update()
    {
        switch (weaponID)
        {
            case 1:
                Debug.Log("You have selected a gun");
                break;
            case 2:
                Debug.Log("You have selected a knife");
                break;
            case 3:
                Debug.Log("You have selected a machine gun");
                break;
            default:
                Debug.Log("No weapon selected");
                break;
        }
    }
}
