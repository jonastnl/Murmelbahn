using UnityEngine;

public class AddForceToSphere : MonoBehaviour
{
    public float forceAmount = 10f; // Einstellbare Kraftmenge

    private Rigidbody rb;

    void Start()
    {
        // Holt den Rigidbody-Komponenten, der an der Kugel befestigt ist
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Überprüft, ob die rechte Pfeiltaste gedrückt wird
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            AddForce(Vector3.forward);
        }

        // Überprüft, ob die linke Pfeiltaste gedrückt wird
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            AddForce(Vector3.back);
        }
    }

    void AddForce(Vector3 direction)
    {
        // Stellt sicher, dass die Richtung normalisiert ist, um eine konsistente Kraft anzuwenden
        Vector3 normalizedDirection = direction.normalized;
        rb.AddForce(normalizedDirection * forceAmount, ForceMode.Impulse);
    }
}
