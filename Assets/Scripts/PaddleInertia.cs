using UnityEngine;
using UnityEngine.InputSystem;

public class MouseAnchorFollow2D : MonoBehaviour
{
    public float followSpeed = 20f;
    Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0;
    }

    void FixedUpdate()
    {
        if (Mouse.current == null) return;

        Vector2 mouseScreen = Mouse.current.position.ReadValue();
        Vector3 mouseWorld = Camera.main.ScreenToWorldPoint(mouseScreen);
        mouseWorld.z = 0f;

        Vector2 targetPos = mouseWorld;
        Vector2 velocity = (targetPos - rb.position) * followSpeed;

        rb.linearVelocity = velocity;
    }
}
