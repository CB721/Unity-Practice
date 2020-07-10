using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDB : MonoBehaviour
{
    public Item[] items;
    public Item sword;
    public Item hammer;
    public Item bread;
    // Start is called before the first frame update
    void Start()
    {
        sword = new Item("Sword", 1, "So sharp and pointy");
        hammer = new Item("Hammer", 2, "Dull but powerful");
        bread = CreateItem("Bread", 3, "Fulling whole grain bread");
    }
    private Item CreateItem(string name, int id, string desc)
    {
        return new Item(name, id, desc);
    }
    
}
