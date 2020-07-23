using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestDB : MonoBehaviour
{
    public List<EnumItem> ItemDB = new List<EnumItem>();
    void Start()
    {
        ItemDB[0].Action();
    }
}
