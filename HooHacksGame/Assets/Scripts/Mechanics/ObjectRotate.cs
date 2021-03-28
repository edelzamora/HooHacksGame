using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ObjectRotate : MonoBehaviour
{
    //Assign a GameObject in the Inspector to rotate around
    public GameObject target;

    public int degreesPerSecond;

    void Update()
    {
        // Spin the object around the target at x degrees/second.
        transform.RotateAround(target.transform.position, Vector3.forward, degreesPerSecond * Time.deltaTime);
    }
}
