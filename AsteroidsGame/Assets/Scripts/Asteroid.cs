using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public GameObject smallAsteroidPrefab;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Destroy(collision.gameObject);

            if (smallAsteroidPrefab != null)
            {
                Instantiate(smallAsteroidPrefab, transform.position, Quaternion.identity);
                Instantiate(smallAsteroidPrefab, transform.position, Quaternion.identity);
            }

            Destroy(gameObject);
        }
    }
}