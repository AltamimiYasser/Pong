using UnityEngine;

public class BouncySurface : MonoBehaviour
{
    [SerializeField] float bounceStrength = 1;
    void OnCollisionEnter2D(Collision2D other)
    {
        BallMovment ball = other.gameObject.GetComponent<BallMovment>();
        if (ball != null)
        {
            Vector2 normals = other.GetContact(0).normal;
            ball.increaseVelocity(-normals * bounceStrength);
        }
    }
}
