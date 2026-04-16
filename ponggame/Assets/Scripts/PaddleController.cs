using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public float speed = 8f;
    public KeyCode upKey;
    public KeyCode downKey;
    public float minY = -3.8f;
    public float maxY = 3.8f;

    void Update()
    {
        float move = 0f;

        if (Input.GetKey(upKey))
            move = 1f;
        else if (Input.GetKey(downKey))
            move = -1f;

        Vector3 newPosition = transform.position + Vector3.up * move * speed * Time.deltaTime;
        newPosition.y = Mathf.Clamp(newPosition.y, minY, maxY);
        transform.position = newPosition;
    }
}