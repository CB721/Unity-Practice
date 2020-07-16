using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item4 {
    public string name;
    public int itemID;
    // each item created will increment the count
    public static int itemCount;
    public Item4(string name, int ID)
    {
        this.name = name;
        this.itemID = ID;
        itemCount++;
    }
}

public class InstanceTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Item4 water = new Item4("water", 1);
        Debug.Log($"Current item count: {Item4.itemCount}");
        Item4 phone = new Item4("phone", 2);
        Debug.Log($"Current item count: {Item4.itemCount}");
    }
}
