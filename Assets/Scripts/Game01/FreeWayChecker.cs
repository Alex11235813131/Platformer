using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreeWayChecker : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody2D;
    [SerializeField] private ContactFilter2D _filter;
    [SerializeField] private float _speed;

    private readonly RaycastHit2D[] _result = new RaycastHit2D[1];

    private void FixedUpdate()
    {
        var collisioncount = _rigidbody2D.Cast(transform.right,_filter, _result, 10);

        if (collisioncount == 0)
            _rigidbody2D.velocity = transform.right * _speed;
        else
            _rigidbody2D.velocity = Vector2.zero;

    }
}
