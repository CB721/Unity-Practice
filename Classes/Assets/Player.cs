using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponStats
{
    public string name;
    public float fireRate;
    public int ammoCount;
    public int minLevel;
    public WeaponStats(string name, float fireRate, int ammoCount, int minLevel)
    {
        this.name = name;
        this.fireRate = fireRate;
        this.ammoCount = ammoCount;
        this.minLevel = minLevel;
    }
}

public class Player : MonoBehaviour
{
    public WeaponStats[] allWeapons;
    private WeaponStats blaster;
    private WeaponStats rocket;
    private WeaponStats mine;
    private WeaponStats sniper;
    public int level;
    public int selectedWeaponIndex;

    void Start()
    {
        AddWeapons();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            PrintWeaponStats();
            CycleWeapons(true);
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            PrintWeaponStats();
            CycleWeapons(false);
        }
    }
    private void PrintWeaponStats()
    {
        Debug.Log($"You are using a {allWeapons[selectedWeaponIndex].name}");
        Debug.Log($"It fires at {allWeapons[selectedWeaponIndex].fireRate} WPS");
        Debug.Log($"It has {allWeapons[selectedWeaponIndex].ammoCount} rounds left");
    }
    private void CycleWeapons(bool cycleRight)
    {
        if (selectedWeaponIndex + 1 < allWeapons.Length && cycleRight)
        {
            selectedWeaponIndex++;
        }
        else if (cycleRight)
        {
            selectedWeaponIndex = 0;
        }
        else if (selectedWeaponIndex - 1 > 0)
        {
            selectedWeaponIndex--;
        }
        else
        {
            selectedWeaponIndex = allWeapons.Length - 1;
        }
    }
    private void AddWeapons()
    {
        blaster = new WeaponStats("Blaster", 0.25f, 50, 1);
        rocket = new WeaponStats("Rocket", 1.75f, 5, 3);
        mine = new WeaponStats("Mine", 0.5f, 7, 2);
        sniper = new WeaponStats("Sniper", 1.75f, 5, 5);
        switch (level)
        {
            case 1:
                allWeapons = new WeaponStats[] { blaster };
                break;
            case 2:
                allWeapons = new WeaponStats[] { blaster, mine };
                break;
            case 3:
                allWeapons = new WeaponStats[] { blaster, mine, rocket };
                break;
            case 5:
                allWeapons = new WeaponStats[] { blaster, mine, rocket, sniper };
                break;
            default:
                break;
        }
    }
}
