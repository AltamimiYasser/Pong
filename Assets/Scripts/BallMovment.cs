using UnityEngine;

public class BallMovment : MonoBehaviour
{
    [SerializeField] float speed = 100f;
    Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        StartMoving();
    }

    public void increaseVelocity(Vector2 strength)
    {
        rb.AddForce(strength);
    }

    public void ResetPosition()
    {
        rb.velocity = Vector2.zero;
        rb.position = Vector2.zero;
        StartMoving();
    }

    void StartMoving()
    {
        rb.AddForce(getRandomDirection() * speed);
    }

    Vector2 getRandomDirection()
    {
        float randomX = getMinusOneOrOne();
        float randomY = Random.Range(-1f, 1f);
        return new Vector2(randomX, randomY);
    }

    float getMinusOneOrOne() => Random.Range(0.0f, 1.0f) > 0.5f ? 1 : -1f;

}
