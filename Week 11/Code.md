 using UnityEngine;
 using TMPro;

 public class Trap : MonoBehaviour
 {
    public PlayerHealth playerHealth;
    public TMP_Text pokeText;
    void Start()
    {

    }

    void Update()
    {

    }

   private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            playerHealth.health -= 10;
            pokeText.text = "POKE!!!";
        }
    }
 }

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