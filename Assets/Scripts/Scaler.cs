using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _scalingSpeed;

    private void Update()
    {
        Scale();
    }

    private void Scale()
    {
        transform.localScale += Vector3.one * _scalingSpeed * Time.deltaTime;
    }
}
