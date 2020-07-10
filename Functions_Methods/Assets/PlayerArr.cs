using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerArr : MonoBehaviour
{
    // create a program that finds all "players"
    // each player should then be given a random color
    public GameObject[] players;
    // Start is called before the first frame update
    void Start()
    {
        players = GetAllPlayers();
    }
    GameObject[] GetAllPlayers()
    {
        GameObject[] allPlayers = GameObject.FindGameObjectsWithTag("Player");
        for (int i = 0; i < allPlayers.Length; i++)
        {
            allPlayers[i].GetComponent<MeshRenderer>().material.color = new Color(Random.value, Random.value, Random.value);
        }
        return allPlayers;
    }
}
