using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class CarMover : MonoBehaviour
{
    public Transform SelfTransform;
    public Tilemap Mep;
    public TileBase GroundTile;
    public float Speed = 0.05f;

    private Vector3 _force;
    private bool _isAccelerated;

    public float GetForce()
    {
        return _force.magnitude;
    }
    public void Accelerate()
    {
        _force += (SelfTransform.up * Time.deltaTime) * Speed;
    }
    public void RotateRight()
    {
        SelfTransform.Rotate(0, 0, -0.5f);
    }
    public void RotateLeft()
    {
        SelfTransform.Rotate(0, 0, 0.5f);
    }

    
    void Start()
    {
        
    }   
    void LateUpdate()
    {   
        if (!_isAccelerated)
        {
            _force = Vector3.Lerp(_force, Vector3.zero, Time.deltaTime);
        }

        if(GroundTile == Mep.GetTile(new Vector3Int((int)SelfTransform.position.x, (int)SelfTransform.position.y, (int)SelfTransform.position.z)))
        {
            _force *= 0.95f;            
        }       
        
        SelfTransform.position += _force;              

        _isAccelerated = false;
    }
}
