using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float _speed;
    private float _jumpForce = 15;
    private Rigidbody2D _rigidbody;
    private int _translateDirection;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A))
        {
            if (Input.GetKey(KeyCode.D))
                _translateDirection = 1;

            if (Input.GetKey(KeyCode.A))
                _translateDirection = -1;

            transform.Translate(_speed * Time.deltaTime * _translateDirection, 0, 0);
        }

        if (Input.GetKey(KeyCode.Space))
        {           
            _rigidbody.AddForce(new Vector2(0, _jumpForce));
        }
    }
}
