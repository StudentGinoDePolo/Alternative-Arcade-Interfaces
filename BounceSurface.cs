using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class BounceSurface : MonoBehaviour
{
    public float bounceStrength; //

    private void OnCollisionEnter2D(Collision2D collision) //Collision has all info about the collision (angle/contact point/normal...)
    {
        Ball ball = collision.gameObject.GetComponent<Ball>();

        if (ball != null) //If Null, the ball collided with something else
        {

            Vector2 normal = collision.GetContact(0).normal; //Apply force to ball in opposite direction of surface to bounce off at the point of contact 0 (Normal is like direction)
            ball.AddForce(-normal * this.bounceStrength); //Negative because we are adding force in opposite direction
        }
    }

}