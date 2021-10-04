using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectibles : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    // identify the collectible when come in contact and destroy
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Hydration"))
        {
            Destroy(collision.gameObject);
            // add particle explosion

            //tick up hydration level

        }
    }

    //public IEnumerator TimeDamage()
    //{
    //    yield return new WaitForSeconds(10f);

    //    TakeDamage(10);
    //}
}
