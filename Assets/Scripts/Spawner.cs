using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Transform _enemy;
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private Transform[] _wayPoints;
    [SerializeField] private float _delay = 2.0f;

    private void Start()
    {
        StartCoroutine(nameof(SpawnEnemy));
    }

    private IEnumerator SpawnEnemy()
    {
        var wait = new WaitForSeconds(_delay);

        while (true)
        {
            yield return wait;

            var spawnPoint = _spawnPoints[Random.Range(0, _spawnPoints.Length)];
            var _wayPoint = _wayPoints[Random.Range(0, _wayPoints.Length)];
            var enemy = Instantiate(_enemy, spawnPoint.position, Quaternion.identity);

            enemy.GetComponent<Mover>().SetWaypoint(_wayPoint.position);
        }
    }
}
