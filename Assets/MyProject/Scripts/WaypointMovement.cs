using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class WaypointMovement : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Transform _path;
    private Animator _animator;
    private readonly int _namberAnimation = Animator.StringToHash("WalkBool"); // имя параметра

    private void Start()
    {
        _animator = GetComponent<Animator>();
        _animator.SetBool(_namberAnimation, true);
    }

    private void Update()
    {
        Transform target = _path;

        var direction = (target.position - transform.position).normalized;

        transform.position = Vector3.MoveTowards(transform.position, target.position, _speed * Time.deltaTime);
    }

    public void Init(Transform target)
    {
        _path = target;
    }
}
