using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public CarMover Car;

    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Car.Accelerate();
        }
        if (Input.GetKey(KeyCode.A))
        {
            Car.RotateLeft();
        }
        if (Input.GetKey(KeyCode.D)) 
        { 
            Car.RotateRight(); 
        }
    }
}
