using System.Collections;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public HealthBar healthBar; // drag healthbar onto slot

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = 50;
        healthBar.SetMaxHealth(maxHealth); // SetMaxHealth is inherited method   
    }

    // Update is called once per frame
    void Update()
    {
        // use spacebar key to test. Use OnTriggerEnter2D like below for game damage
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(20);
        }
    }

    public void TakeDamage(int damage)
    {
        // add/subtract life depending if operator is += or -=
        currentHealth -= damage;

        // updates healthbar display to reflect above action
        healthBar.SetHealth(currentHealth);
    }

    public void AddLife(int damage)
    {
        // add/subtract life depending if operator is += or -=
        currentHealth += damage;

        // updates healthbar display to reflect above action
        healthBar.SetHealth(currentHealth); // inherited funct.
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Hydration"))
        {
            AddLife(15);

            StartCoroutine(TimeDamage());
        }
    }

    public IEnumerator TimeDamage()
    {
        yield return new WaitForSeconds(10f);

        TakeDamage(10);
    }
}
