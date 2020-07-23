using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private ItemDB _itemDB;
    public Item[] inventory = new Item[10];
    void Start()
    {
        _itemDB = GameObject.Find("ItemDB").GetComponent<ItemDB>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _itemDB.AddItem(0, this);
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            _itemDB.RemoveItem(0, this);
        }
    }
}
