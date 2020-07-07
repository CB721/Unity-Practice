using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speed : MonoBehaviour
{
    // create a program that does the following
    // takes the maximum speed
    // shows the user their current speed
    // takes in the rate of acceleration
    // every acceleration rate, increment the speed by 5
    // once the max speed is reached, print 'Max speed reached'
    private int _speed;
    public int maxSpeed = 50;
    public float acceleration = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Accelerate());
    }

    // Update is called once per frame
    void Update()
    {
        if (_speed >= maxSpeed)
        {
            _speed = maxSpeed;
            Debug.Log("Max speed reached");
        }
    }
    IEnumerator Accelerate()
        {
            while (_speed < maxSpeed)
            {
                _speed += 5;
                Debug.Log($"You current speed is {_speed}");
                yield return new WaitForSeconds(acceleration);
            }
        }
}
