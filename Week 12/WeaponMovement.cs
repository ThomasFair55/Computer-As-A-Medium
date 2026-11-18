using UnityEngine;

public class WeaponMovement : MonoBehaviour
{
    public PlayerMovement playerMovement;

    void Start()
    {
        if (playerMovement == null)
        {
            playerMovement = GetComponentInParent<PlayerMovement>();
        }
    }

    void Update()
    {
        if (playerMovement == null) return;

        Vector2 dir = playerMovement.facingDirection;
        if (dir == Vector2.zero) return;

        
        float adjustedX = (transform.lossyScale.x < 0) ? -dir.x : dir.x;

        float angle = Mathf.Atan2(dir.y, adjustedX) * Mathf.Rad2Deg;
        transform.localRotation = Quaternion.Euler(0f, 0f, angle);
    }
}
