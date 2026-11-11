using UnityEngine;

public class HealthPack : MonoBehaviour
{
    public PlayerHealth playerHealth;

    void Start()
    {

    }

    private void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (playerHealth != null)
            {
                
                if (playerHealth.health == 100)
                {
                    
                }
               
                else
                {
                    playerHealth.health += 10;

                   
                    if (playerHealth.health > 100)
                    {
                        playerHealth.health = 100;
                    }

                    
                    Destroy(gameObject);
                }
            }
        }
    }
}
