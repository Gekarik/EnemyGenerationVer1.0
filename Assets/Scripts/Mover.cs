using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _movingSpeed;

    private Vector3 _movementDirection = Vector3.forward;

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.Translate(_movementDirection * _movingSpeed * Time.deltaTime);
    }
}
