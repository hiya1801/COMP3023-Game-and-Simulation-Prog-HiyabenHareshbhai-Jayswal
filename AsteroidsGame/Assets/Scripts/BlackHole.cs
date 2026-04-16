using UnityEngine;

public class BlackHole : MonoBehaviour
{
    public float pullForce = 5f;

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.attachedRigidbody != null)
        {
            Vector2 dir = (transform.position - other.transform.position).normalized;
            other.attachedRigidbody.AddForce(dir * pullForce);
        }
    }
}