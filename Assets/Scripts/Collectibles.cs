using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectibles : MonoBehaviour
{
    // identify the collectible when come in contact and destroy
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Hydration"))
        {
            // Destroy water bottle on collision
            Destroy(collision.gameObject);
        }
    }
}
