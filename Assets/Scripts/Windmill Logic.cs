using UnityEngine;

public class WindmillSpin : MonoBehaviour
{
    public float maxSpeed = 25f;
    public GameObject popup;

    Rigidbody2D rb;
    bool done;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void AddSpin(float amount)
    {
        if (done) return;

        rb.angularVelocity += amount;
        rb.angularVelocity = Mathf.Clamp(rb.angularVelocity, -maxSpeed, maxSpeed);

        if (Mathf.Abs(rb.angularVelocity) >= maxSpeed)
        {
            done = true;
            popup.SetActive(true);
        }
    }
}
