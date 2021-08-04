using UnityEngine;

[RequireComponent(typeof(SpriteRenderer), typeof(Rigidbody2D), typeof(Animator))]
public class Movement : MonoBehaviour
{
    [SerializeField] private float _speed;
    private float _jumpSpeed = 15;
    private Animator _animator;
    private SpriteRenderer _playerDirection;
    private Rigidbody2D _rigidbody;

    private void Awake()
    {
        _playerDirection = GetComponent<SpriteRenderer>();
        _rigidbody = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(_speed * Time.deltaTime, 0, 0);
            _playerDirection.flipX = false;
            _animator.SetTrigger("Walk");
        }
            
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(_speed * Time.deltaTime * -1, 0, 0);
            _playerDirection.flipX = true;
            _animator.SetTrigger("Walk");
        }

        if (Input.GetKey(KeyCode.Space))
        {           
            _rigidbody.AddForce(new Vector2(0, _jumpSpeed));
        }
    }
}
