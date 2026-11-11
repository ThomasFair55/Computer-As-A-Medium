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
