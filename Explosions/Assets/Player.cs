using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float _horSpeed = 0;
    [SerializeField]
    private float _verSpeed = 0;
    [SerializeField]
    private float _horizontal;
    [SerializeField]
    private float _vertical;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        _horizontal = Input.GetAxis("Horizontal");
        _vertical = Input.GetAxis("Vertical");
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            while (_horSpeed < 10)
            {
                _horSpeed += 1;
            }
        }
        if (Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.LeftArrow))
        {
            while (_horSpeed > 0)
            {
                _horSpeed -= 1;
            }
        }
        transform.Translate(new Vector3(_horizontal, 0, 0) * _horSpeed * Time.deltaTime);
        transform.Translate(new Vector3(0, _vertical, 0) * _verSpeed * Time.deltaTime);
    }
}
