using UnityEngine;

public class PaddleBounce : MonoBehaviour
{
    public float bounceStrength = 10f;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            Rigidbody2D ballRb = collision.gameObject.GetComponent<Rigidbody2D>();

            float hitPoint = collision.transform.position.y - transform.position.y;
            float paddleHeight = GetComponent<Collider2D>().bounds.size.y;

            float normalizedHit = hitPoint / (paddleHeight / 2f);

            float xDirection = collision.transform.position.x > transform.position.x ? 1f : -1f;
            Vector2 newDirection = new Vector2(xDirection, normalizedHit).normalized;

            ballRb.linearVelocity = newDirection * bounceStrength;
        }
    }
}