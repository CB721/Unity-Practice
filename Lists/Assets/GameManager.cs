using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // create a list of names and print out each one
    // when the space key is pressed, remove a random name and print out all of the names again
    public List<string> names = new List<string>();
    void Start()
    {
        names.Add("Clint");
        names.Add("Amanda");
        names.Add("Charlie");
        names.Add("R2D2");
        names.Add("Mario");
        names.Add("Luigi");
        names.Add("Spencer");
        names.Add("Carla");
        _PrintNames();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && names.Count > 0) {
            int index = Random.Range(0, names.Count - 1);
            names.RemoveAt(index);
            _PrintNames();
        }
    }
    private void _PrintNames()
    {
        names.ForEach(name => {
            Debug.Log(name);
        });
        Debug.Log("---------------------");
    }
}
