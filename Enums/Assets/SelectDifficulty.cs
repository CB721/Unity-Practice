using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectDifficulty : MonoBehaviour
{
    public enum LevelSelector
    {
        Easy,
        Normal,
        Hard,
        Expert
    }
    public LevelSelector currLevel;
    void Start()
    {
        Debug.Log($"You selected the {currLevel} level!");
    }
}
