using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _threshold = 0.1f;
    
    private Vector3 _movementDirection;
    private Vector3 _targetPosition;

    public void SetWaypoint(Vector3 movementDirection, Vector3 targetPosition)
    {
        _movementDirection = movementDirection.normalized;
        _targetPosition = targetPosition;
    }

    private void Update()
    {
        if (_movementDirection != Vector3.zero && Vector3.Distance(transform.position, _targetPosition) > _threshold)
        {
            Move();
        }
        else if (Vector3.Distance(transform.position, _targetPosition) <= _threshold)
        {
            Destroy(gameObject);
        }
    }

    private void Move()
    {
        transform.Translate(_movementDirection * _speed * Time.deltaTime, Space.World);
    }
}
