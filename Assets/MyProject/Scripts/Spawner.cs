using System.Collections;
using UnityEngine;
using Random = System.Random;

public class Spawner : MonoBehaviour
{
    [SerializeField] private WaypointMovement _crussader;
    [SerializeField] private Transform _target;
    [SerializeField] private float _delay;
    [SerializeField] private int _enemiesCount;

    private Transform[] _spawnPoints;
    private WaitForSeconds _waitForSeconds;
    private Coroutine _coroutine;

    private Random _random = new Random();

    private void Start()
    {
        _waitForSeconds = new WaitForSeconds(_delay);

        _spawnPoints = gameObject.GetComponentsInChildren<Transform>();

        _coroutine = StartCoroutine(Create());
    }

    private IEnumerator Create()
    {

        for (int i = 1; i < _enemiesCount; i++)
        {
            int randomPoint = _random.Next(_spawnPoints.Length);

            WaypointMovement crussader = Instantiate(_crussader, _spawnPoints[randomPoint].position, Quaternion.identity);
            crussader.Init(_target);

            yield return _waitForSeconds;
        }

        StopCoroutine(_coroutine);
    }
}
