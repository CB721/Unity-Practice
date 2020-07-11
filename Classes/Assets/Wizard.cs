using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wizard : MonoBehaviour
{
    Spell fireBlast;
    public int level = 1;
    public int exp;
    void Start()
    {
        fireBlast = new Spell("Fire Blast", 1, 27, 35);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            fireBlast.Cast();
            exp += fireBlast.expGained;
        }
    }
}
