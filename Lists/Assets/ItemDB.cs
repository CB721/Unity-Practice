using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDB : MonoBehaviour
{
    public List<Item> itemDB = new List<Item>();

    // pass in id of item and a reference to the player to adjust their inventory
    public void AddItem(int id, Player player)
    {
        // iterate through all items and see if the id passed in exists
        itemDB.ForEach(item =>
        {
            // if there is a match
            if (item.id == id)
            {
                Debug.Log("There is a match");
                // add to the player's inventory
                player.inventory[0] = item;
                return;
            }
        });
        Debug.Log("Item does not exist");
    }
    // pass in id of item and a reference to the player to adjust their inventory
    public void RemoveItem(int id, Player player)
    {
        // iterate through all items and see if the id passed in exists
        itemDB.ForEach(item =>
        {
            // if there is a match
            if (item.id == id)
            {
                Debug.Log("There is a match");
                // set the value to null since it is an array and cannot be removed
                player.inventory[0] = null;
                return;
            }
        });
        Debug.Log("Item does not exist");
    }
}
