using UnityEngine;

public class DestroyAfterTime : MonoBehaviour
{
    // Time in seconds before the object is destroyed
    public float delay = 1f;

    private void Start()
    {
        // Call the DestroyObject method after 'delay' seconds
        Invoke("DestroyObject", delay);
    }

    private void DestroyObject()
    {
        // Destroy the current GameObject
        Destroy(gameObject);
    }
}
