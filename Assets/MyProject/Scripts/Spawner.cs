using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using Random = System.Random;

public class Spawner : MonoBehaviour
{
    [SerializeField] private WaypointMovement _crussader;
    [SerializeField] private List<Transform> _points = new List<Transform>();
    [SerializeField] private float _delay;

    private float _currentTime = 0;

    //Random _random = new Random();

    private void Start()
    {
        _currentTime = _delay;
    }

    void Update()
    {
        if(_currentTime <= 0)
        {
            _currentTime = _delay;
            WaypointMovement crussader = Instantiate(_crussader, _points[0].position, Quaternion.identity);
            crussader.Init(_points[1]);
        }
        else
        {
            _currentTime -= Time.deltaTime;
        }
    }
}
