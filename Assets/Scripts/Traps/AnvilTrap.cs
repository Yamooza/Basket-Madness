using UnityEngine;

public class AnvilTrap: MonoBehaviour
{
    // This method is called when another collider enters the trigger collider attached to the GameObject where this script is attached
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the object that entered the trigger has the "Player" tag
        if (other.CompareTag("Player"))
        {
            // Find all objects with the tag "Anvil"
            GameObject[] anvils = GameObject.FindGameObjectsWithTag("Anvil");

            // Loop through each anvil and enable its Rigidbody2D component
            foreach (GameObject anvil in anvils)
            {
                Rigidbody2D rb = anvil.GetComponent<Rigidbody2D>();
                if (rb != null)
                {
                    rb.isKinematic = false; // Set isKinematic to false to allow falling
                }
            }
        }
    }
}