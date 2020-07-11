using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wizard : MonoBehaviour
{
    public Spell[] spells;
    public int level = 1;
    public int exp;
    void Start()
    {
        
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // iterate through spell list
            // compare to current level
            foreach (var spell in spells)
            {
                if (spell.levelRequired == level)
                {
                    spell.Cast();
                    exp += spell.expGained;
                }
            }
        }
    }
}
