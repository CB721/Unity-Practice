using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public enum EnemyState
    {
        Patrolling,
        Attacking,
        Chasing,
        Death
    }
    public EnemyState currState;

    void Update()
    {
        switch (currState)
        {
            case EnemyState.Patrolling:
                Debug.Log("The enemy is patrolling...");
                // time.time is how many seconds the game has been running
                if (Time.time > 5)
                {
                    currState = EnemyState.Chasing;
                }
                break;
            case EnemyState.Attacking:
                Debug.Log("The enemy is attacking!");
                break;
            case EnemyState.Chasing:
                Debug.Log("The enemy is chasing!");
                break;
            case EnemyState.Death:
                Debug.Log("The enemy has died.");
                break;
            default:
                return;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            currState = EnemyState.Attacking;
        }
    }
}
