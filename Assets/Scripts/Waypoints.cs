using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoints : MonoBehaviour
{
    public static Transform[] points;
    //new method to make the AI move

    void Awake()
    {
        points = new Transform[transform.childCount];
        for(int i = 0; i<points.Length; i++)
        {
            points[i] = transform.GetChild(i);
        }
    }
}
