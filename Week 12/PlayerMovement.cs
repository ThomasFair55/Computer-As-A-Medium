using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    private float speedX = 0f;
    private float speedY = 0f;
    public Rigidbody2D rb;

    public SpriteRenderer spriteRenderer;

    public Sprite beartop;
    public Sprite beardown;
    public Sprite bearleft;
    public Sprite bearright;

   
    [HideInInspector] public Vector2 facingDirection = Vector2.down;

    void Start()
    {

    }

    void Update()
    {
        Movement();
    }

    void Movement()
    {
        // Horizontal Movement
        if (Keyboard.current.aKey.isPressed)
        {
            speedX = -moveSpeed;
            spriteRenderer.sprite = bearleft;
            facingDirection = Vector2.left; // 2. UPDATE IT HERE
        }
        else if (Keyboard.current.dKey.isPressed)
        {
            speedX = moveSpeed;
            spriteRenderer.sprite = bearright;
            facingDirection = Vector2.right; // 3. UPDATE IT HERE
        }
        else
        {
            speedX = 0;
        }

        // Vertical Movement
        if (Keyboard.current.wKey.isPressed)
        {
            speedY = moveSpeed;
            spriteRenderer.sprite = beartop;
            facingDirection = Vector2.up; // 4. UPDATE IT HERE
        }
        else if (Keyboard.current.sKey.isPressed)
        {
            speedY = -moveSpeed;
            spriteRenderer.sprite = beardown;
            facingDirection = Vector2.down; // 5. UPDATE IT HERE
        }
        else
        {
            speedY = 0;
        }

        rb.linearVelocity = new Vector2(speedX, speedY);
    }
}
