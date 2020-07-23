﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        SceneManager.LoadScene((int)currLevel);
    }
}
