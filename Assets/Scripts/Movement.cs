using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private bool _isRotate;
    [SerializeField] private bool _isMoving;
    [SerializeField] private bool _isScaling;
    [SerializeField] private float _movingSpeed;
    [SerializeField] private float _rotationSpeed;
    [SerializeField] private float _scalingSpeed;

    private Vector3 _movementDirection = Vector3.forward;
    private Vector3 _rotationDirection = Vector3.up;

    private void Update()
    {
        if (_isRotate)
            Rotate();

        if (_isMoving)
            Move();

        if (_isScaling)
            Scale();
    }

    private void Move()
    {
        transform.Translate(_movementDirection * _movingSpeed * Time.deltaTime);
    }

    private void Scale()
    {
        transform.localScale += Vector3.one * _scalingSpeed * Time.deltaTime;
    }

    public void Rotate()
    {
        transform.Rotate(_rotationDirection * _rotationSpeed * Time.deltaTime);
    }
}
