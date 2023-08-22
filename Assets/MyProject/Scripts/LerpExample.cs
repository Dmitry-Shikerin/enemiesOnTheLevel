using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpExample : MonoBehaviour
{
    [SerializeField] private Transform _a;
    [SerializeField] private Transform _b;
    [SerializeField] private Transform _enemiePoint;

    [SerializeField] private float _pathTime;
    [SerializeField] private float _pathRunningTime;

    private void Update()
    {
        _pathRunningTime += Time.deltaTime;
        _enemiePoint.position = Vector3.Lerp(_a.position, _a.position, _pathRunningTime / _pathTime);
    }

    public void SetNormalizedPosition(float position)
    {
        _enemiePoint.position = Vector3.Lerp(_a.position, _b.position, position);
    }
}
