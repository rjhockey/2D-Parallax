using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropEffect : MonoBehaviour
{
    ParticleSystem collectWater;

    private void Start()
    {
        collectWater = GetComponent<ParticleSystem>();
        collectWater.Pause();
    }

    // identify the collectible when come in contact and destroy
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("playa");
            // activate particle explosion
            collectWater.Play();
        }
    }
}
