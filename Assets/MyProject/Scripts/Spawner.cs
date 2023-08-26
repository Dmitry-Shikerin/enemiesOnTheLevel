using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class Spawner : MonoBehaviour
{
    [SerializeField] private WaypointMovement _crussader;
    [SerializeField] private List<Transform> _points = new List<Transform>();
    [SerializeField] private Transform _target;
    [SerializeField] private float _delay;

    private float _currentTime = 0;

    Random _random = new Random();
   
    private void Start()
    {
        _currentTime = _delay;
    }

    void Update()
    {
        int randomPoint = _random.Next(_points.Count);

        if(_currentTime <= 0)
        {
            _currentTime = _delay;
            WaypointMovement crussader = Instantiate(_crussader, _points[randomPoint].position, Quaternion.identity);
            crussader.Init(_target);
        }
        else
        {
            _currentTime -= Time.deltaTime;
        }
    }
}
