using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] protected float speed = 10f;

    protected Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void ResetPosition() => rb.position = new Vector2(rb.position.x, 0);
}
