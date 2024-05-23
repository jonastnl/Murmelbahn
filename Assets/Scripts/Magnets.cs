using UnityEngine;

public class Magnet : MonoBehaviour
{
    public int activationKey; // The key number to activate this magnet (1-10)
    public float magneticForce = 100f; // The force applied to the marble

    private bool isActive = false;
    private Transform marbleTransform;

    void Start()
    {
        marbleTransform = GameObject.FindGameObjectWithTag("Marble").transform;
    }

    void Update()
    {
        // Check if the corresponding key is pressed to toggle the magnet
        if (Input.GetKeyDown((KeyCode) (KeyCode.Alpha1 + activationKey - 1)))
        {
            isActive = !isActive;
        }
        
        // Apply force if the magnet is active
        if (isActive)
        {
            Vector3 direction = transform.position - marbleTransform.position;
            marbleTransform.GetComponent<Rigidbody>().AddForce(direction.normalized * magneticForce * Time.deltaTime);
        }
    }
}
