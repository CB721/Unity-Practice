using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim : MonoBehaviour
{
    // reference to the focus cube
    [SerializeField]
    private Transform _focusCube;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // direction = destination - source
        // should return a vector3
        Vector3 direction = _focusCube.position - transform.position;
        Debug.DrawRay(transform.position, direction, Color.green);
        // access our current location = Quaternion look rotation
        transform.rotation = Quaternion.LookRotation(direction);
    }
}
