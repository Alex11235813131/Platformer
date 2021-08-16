using UnityEngine;

public class CoinCollector : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.TryGetComponent<Coin>(out Coin coin))
        {
            Destroy(collision.gameObject);
        }           
    }
}
