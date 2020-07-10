using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int health = 100;
    public int attack = 5;
    [SerializeField]
    private float _horSpeed = 0;
    [SerializeField]
    private float _verSpeed = 0;
    [SerializeField]
    private float _horizontal;
    [SerializeField]
    private float _vertical;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Damage(attack);
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            ChangePosition(new Vector3(0, 0.5f, -245));
        }
        _horizontal = Input.GetAxis("Horizontal");
        _vertical = Input.GetAxis("Vertical");
        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            StartCoroutine(ChangeSpeed(true, true));
        }
        else if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            StartCoroutine(ChangeSpeed(true, false));
        }
        Debug.Log($"Your horizontal speed is {_horSpeed}");
        Debug.Log($"Your vertical speed is {_verSpeed}");
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
    private void ChangePosition(Vector3 pos)
    {
        transform.position = pos;
    }
    private void ChangeTranslate(Vector3 pos, bool isHorizontal)
    {
        if (isHorizontal)
        {
            transform.Translate(pos * _horSpeed * Time.deltaTime);
        }
        else
        {
            transform.Translate(pos * _verSpeed * Time.deltaTime);
        }
    }
    IEnumerator ChangeSpeed(bool isHorizontal, bool isForwards)
    {
        // for horizontal values, forwards = right
        if (isHorizontal && isForwards)
        {
            while (_horSpeed < 10)
            {
                _horSpeed += 1;
                ChangeTranslate(new Vector3(_horizontal, 0, 0), true);
                ChangeTranslate(new Vector3(0, _vertical, 0), true);
                yield return new WaitForSeconds(1.0f);
            }
        }
        else if (isHorizontal)
        {
            while (_horSpeed > 0)
            {
                _horSpeed -= 1;
                ChangeTranslate(new Vector3(_horizontal, 0, 0), false);
                ChangeTranslate(new Vector3(0, _vertical, 0), true);
                yield return new WaitForSeconds(1.0f);
            }
        }
    }
}
