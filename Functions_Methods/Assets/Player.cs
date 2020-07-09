using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int health = 100;
    public int attack = 5;
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Damage(attack);
        }
    }

    private void Damage(int amount)
    {
        health = health - amount;
        Debug.Log(health);
        if (health <= 0)
        {
            health = 0;
            Revive();
        }
    }
    private void Revive()
    {
        health = 100;
        Debug.Log("You have been revived!");
    }
}
