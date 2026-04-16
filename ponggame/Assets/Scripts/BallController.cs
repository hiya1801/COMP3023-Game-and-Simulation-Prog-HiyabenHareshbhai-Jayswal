using UnityEngine;

public class BallController : MonoBehaviour
{
    public float speed = 8f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        LaunchBall();
    }

    public void LaunchBall()
    {
        transform.position = Vector3.zero;

        float xDirection = Random.value < 0.5f ? -1f : 1f;
        float yDirection = Random.Range(-0.8f, 0.8f);

        Vector2 direction = new Vector2(xDirection, yDirection).normalized;
        rb.linearVelocity = direction * speed;
    }

    public void ResetBall()
    {
        rb.linearVelocity = Vector2.zero;
        transform.position = Vector3.zero;
        LaunchBall();
    }
}