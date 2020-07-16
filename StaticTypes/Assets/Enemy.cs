using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private UIManager _ui;
    // when the enemy is created
    public void OnEnable()
    {
        // increment the enemy count
        SpawnManager.counter++;
        UpdateUIText();
        Die();
    }
    // when the enemy is destroyed
    public void OnDisable()
    {
        // decrement the enemy count
        SpawnManager.counter--;
        UpdateUIText();
    }
    private void UpdateUIText()
    {
        // grab a reference to the UI manager component
        _ui = GameObject.Find("UI Manager").GetComponent<UIManager>();
        // update the text displayed with the new count
        _ui.UpdateEnemyCount();
    }

    private void Die()
    {
        // destroy the enemy at a random interval between 2 and 5 seconds
        Destroy(this.gameObject, Random.Range(2, 6));
    }
}
