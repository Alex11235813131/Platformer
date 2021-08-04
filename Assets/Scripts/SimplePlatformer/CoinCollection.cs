using UnityEngine;

public class CoinCollection : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.TryGetComponent<Player>(out Player player))
            Destroy(gameObject);
    }
}
