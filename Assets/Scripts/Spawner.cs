using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject _enemy;
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private Transform[] _wayPoints;

    private void Start()
    {
        StartCoroutine(nameof(SpawnEnemy));
    }

    private IEnumerator SpawnEnemy()
    {
        while (true)
        {
            yield return new WaitForSeconds(2f);

            var spawnPoint = _spawnPoints[Random.Range(0, _spawnPoints.Length)];
            var _wayPoint = _wayPoints[Random.Range(0, _wayPoints.Length)];
            var enemy = Instantiate(_enemy, spawnPoint.position, Quaternion.identity);

            enemy.GetComponent<Mover>().SetWaypoint(_wayPoint.position);
        }
    }
}
