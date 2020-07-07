using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SingleItem
{
    public int ID;
    public string name;
    public string description;
}

public class Item : MonoBehaviour
{
    public SingleItem[] myItems;
    // Start is called before the first frame update
    void Start()
    {
        foreach (var item in myItems)
        {

            Debug.Log(item.name);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log(myItems[Random.Range(0, myItems.Length)].name);
        }
    }
}
