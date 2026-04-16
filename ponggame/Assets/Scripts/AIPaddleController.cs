using UnityEngine;

public class AIPaddleController : MonoBehaviour
{
    public Transform ball;
    public float speed = 6f;
    public float minY = -3.8f;
    public float maxY = 3.8f;

    void Update()
    {
        if (ball == null) return;

        Vector3 targetPosition = new Vector3(transform.position.x, ball.position.y, transform.position.z);
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

        Vector3 clampedPosition = transform.position;
        clampedPosition.y = Mathf.Clamp(clampedPosition.y, minY, maxY);
        transform.position = clampedPosition;
    }
}