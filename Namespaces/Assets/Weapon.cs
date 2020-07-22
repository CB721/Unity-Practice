using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
// import classes from our own created namespace
using WeaponPack;

public class Weapon : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        WeaponPack.Weapon = new WeaponPack.Weapon();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
