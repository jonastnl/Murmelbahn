using UnityEngine;

public class Marble : MonoBehaviour
{
    void Start()
    {
        // Ensure the marble has a Rigidbody component
        Rigidbody rb = GetComponent<Rigidbody>();
        if (rb == null)
        {
            rb = gameObject.AddComponent<Rigidbody>();
        }
        rb.useGravity = true;
    }

    // You can add collision handling here if needed
}
