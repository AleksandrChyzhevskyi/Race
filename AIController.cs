using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIController : MonoBehaviour
{
    public Transform[] Waypoints;
    public Transform Selftransform;
    public CarMover Car;
    private int _currentPoins;
    void Update()
    {
        Transform current = Waypoints[_currentPoins];
        Debug.DrawLine(Selftransform.position, current.position, Color.red);

        Vector3 direction = Selftransform.position - current.position;
        float angel = Vector3.Dot(direction, -Selftransform.right);

        if(angel > 0)
        {
            Car.RotateRight();
        }
        else if(angel == 0)
        {
            
        }
        else
        {
            Car.RotateLeft();
        }

        if (angel < 0.2f && angel > -0.2f)
        {
            Car.Accelerate();
        }

        if(Vector3.Distance(Selftransform.position, current.position) < 1f)
        {
            _currentPoins++;

            if (_currentPoins == Waypoints.Length)
            {
                _currentPoins = 0;
            }            
        }
    }
}
