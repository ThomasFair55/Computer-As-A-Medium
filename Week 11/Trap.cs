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
