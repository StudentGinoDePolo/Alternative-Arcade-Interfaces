using UnityEngine;

public class ComputerPaddle : Paddle //Inheriting values from Paddle just like Player Paddle BUT values are still different
{
    public Rigidbody2D ball; //Manually referencing ball 

    private void FixedUpdate()
    {

        if (this.ball.velocity.x > 0.0f) // If ball is moving towards paddle (+ x velocity) or away (- x velocity)
        {
            // Move the paddle in the direction of the ball to track it
            if (this.ball.position.y > this.rigidbody.position.y)
            {
                this.rigidbody.AddForce(Vector2.up * this.speed);
            }
            else if (this.ball.position.y < this.rigidbody.position.y) 
            {
                this.rigidbody.AddForce(Vector2.down * this.speed);
            }
        }
        else //Ball is moving away
        {

            if (this.rigidbody.position.y > 0.0f) //Move down if paddle is up
            {
                this.rigidbody.AddForce(Vector2.down * this.speed);
            }
            else if (this.rigidbody.position.y < 0.0f) //Move up if paddle is down
            {
                this.rigidbody.AddForce(Vector2.up * this.speed);
            }
        }
    }

}
