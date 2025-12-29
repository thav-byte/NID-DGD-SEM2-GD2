using UnityEngine;
using UnityEngine.InputSystem;

public class CursorFollow : MonoBehaviour
{
    void Update()
    {
        if (Mouse.current == null) return;

        Vector2 screen = Mouse.current.position.ReadValue();
        Vector3 world = Camera.main.ScreenToWorldPoint(screen);
        world.z = 0;

        transform.position = world;
    }
}
