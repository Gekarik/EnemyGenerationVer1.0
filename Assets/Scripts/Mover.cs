using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Vector3 _targetPosition;

    public void SetWaypoint(Vector3 movementDirection)
    {
        _targetPosition = movementDirection;
    }

    private void Update()
    {
        if (_targetPosition != null)
            Move();
        if (_targetPosition == transform.position)
            Destroy(gameObject);
    }

    private void Move()
    {
        transform.position = Vector3.MoveTowards(transform.position, _targetPosition, _speed * Time.deltaTime);
    }
}
