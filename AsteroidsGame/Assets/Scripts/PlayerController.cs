using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float thrustForce = 5f;
    public float rotationSpeed = 200f;
    public GameObject bulletPrefab;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // ROTATE (A / D)
        float rotate = Input.GetAxis("Horizontal");
        transform.Rotate(0, 0, -rotate * rotationSpeed * Time.deltaTime);

        // MOVE FORWARD (W)
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(transform.up * thrustForce);
        }

        // SHOOT (SPACE)
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bulletPrefab, transform.position, transform.rotation);
        }
    }
}