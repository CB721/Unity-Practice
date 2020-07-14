using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct Item2 
// value type - stored on a stack - can't be modified
// bool, bytes, char, doubles, floats, int, long, structs
{
    public string itemName;
    public int itemID;
    public Item2(string itemName, int itemID)
    {
        this.itemName = itemName;
        this.itemID = itemID;
    }
}
public class Item3 
// reference type - stored on a heap - can be modified
// strings, arrays, classes, delegates
{
    public string itemName;
    public int itemID;
    public Item3(string itemName, int itemID)
    {
        this.itemName = itemName;
        this.itemID = itemID;
    }
}
public class Test : MonoBehaviour 
{
    Item3 sword = new Item3("sword", 1);
    Item2 hammer;
    private void Start() {
        hammer.itemName = "hammer";
        hammer.itemID = 2;
        Debug.Log($"sword current name: {sword.itemName}");
        ChangeValue2(sword);
        Debug.Log($"sword current name after method: {sword.itemName}");
        Debug.Log("--------------------------------------------------");
        Debug.Log($"hammer current name: {hammer.itemName}");
        ChangeValue(hammer);
        Debug.Log($"hammer current name after method: {hammer.itemName}");
    }
    private void ChangeValue(Item2 structItem) // value type
    {
        structItem.itemName = "Master hammer";
    }
    private void ChangeValue2(Item3 classItem) // reference type
    {
        classItem.itemName = "master sword";
    }
}
