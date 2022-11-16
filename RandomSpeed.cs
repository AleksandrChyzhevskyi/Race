using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpeed : MonoBehaviour
{
    public CarMover Car;
    
    void Start()
    {
        Car.Speed = Random.Range(0.05f, 0.5f);
    }   
}
