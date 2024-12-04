using UnityEngine;

public class Shopkeepper : MonoBehaviour
{
    public float hoverHeight = 4.2f; // The target height
    public float hoverRange = 0.1f; // The range of floating (0.1 means from 4.1 to 4.3)
    public float speed = 2.0f; // Speed of the floating motion

    private float startY;

    void Start()
    {
        // Store the initial Y position
        startY = transform.position.y;
    }

    void Update()
    {
        // Calculate the new Y position using a sine wave for smooth oscillation
        float newY = hoverHeight + Mathf.Sin(Time.time * speed) * hoverRange;

        // Update the object's position
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }
}