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

using UnityEngine;
using TMPro;

public class Mana : MonoBehaviour
{
    public int mana = 100;
    public TMP_Text manaText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        manaText.text = "Mana: " + mana; 
    }

    // Update is called once per frame
    void Update()
    {
        manaText.text = "Mana: " + mana;
    }
}

using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerRangedAttack : MonoBehaviour
{
    public Animator animator;
    public Mana PlayerMana;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        RangedAttack();
    }

    void RangedAttack()
    {
        if (Keyboard.current.eKey.wasPressedThisFrame)
        {
            animator.SetBool("mana", true);
            PlayerMana.mana -= 10;
        }
        else
        {
            animator.SetBool("mana", false);
        }
    }
}