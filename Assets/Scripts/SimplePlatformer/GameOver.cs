using UnityEngine;

public class GameOver : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.TryGetComponent<EnemyWasp>(out EnemyWasp wasp))
        {
            Destroy(gameObject);
            Time.timeScale = 0;
            Debug.Log("Game Over");
        }
    }
}
