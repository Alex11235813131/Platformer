using UnityEngine;

[RequireComponent(typeof(Animator), typeof(SpriteRenderer))]
public class PlayerAnimator : MonoBehaviour
{
    private Animator _animator;
    private SpriteRenderer _renderDirection;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
        _renderDirection = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A))
        {
            _animator.SetTrigger("Walk");

            if (Input.GetKey(KeyCode.D))
                _renderDirection.flipX = false;

            if (Input.GetKey(KeyCode.A))
                _renderDirection.flipX = true;
        }
    }
}
