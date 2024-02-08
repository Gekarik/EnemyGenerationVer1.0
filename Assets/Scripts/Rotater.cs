using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotater : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed;

    private Vector3 _rotationDirection = Vector3.up;

    private void Update()
    {
        Rotate();
    }

    public void Rotate()
    {
        transform.Rotate(_rotationDirection * _rotationSpeed * Time.deltaTime);
    }
}
