using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Utility
{
    public static void CreateGameObject()
    {
        // create a basic cube
        GameObject.CreatePrimitive(PrimitiveType.Cube);
    }
    public static void SetPositionToZero(GameObject obj)
    {
        // change position of the object
        obj.transform.position = Vector3.zero;
    }
    public static void ChangeColor(GameObject obj, Color color)
    {
        obj.GetComponent<Renderer>().material.color = color;
    }
}
