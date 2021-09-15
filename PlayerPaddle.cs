using UnityEngine;

public class PlayerPaddle : Paddle
{
    public Vector2 direction { get; private set; } //Keeps track of paddle movement

    public float mouseSensitivity = 1000f; //Vary value based on Bongo input


    private void Update() //Executed every frame of game
    {

        //Mouse input based on Y movement only
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        //float mouseY = Input.GetAxis("Mouse Y");

        if (mouseY > 0)
        {
            this.direction = Vector2.up;
            this.speed = mouseY;
        }
        else if(mouseY < 0)
        {
            this.direction = Vector2.down;
            this.speed = -mouseY;
        }
        else
        {
            this.direction = Vector2.zero;

        }

       // this.direction = new Vector2 (0.0f, mouseY);

        /* ORIGINAL KEYBOARD INPUT
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) //When W or Up Arrow are pressed
        {
            this.direction = Vector2.up; //Vector2 direction set
        }
        else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) //When S or Down Arrow are pressed
        {
            this.direction = Vector2.down; 
        }
        else
        {
            this.direction = Vector2.zero; //Not moving because W,Up,S,Down has not been pressed
        }
        */
    }

    private void FixedUpdate() //Physics based execution at a fixed rate
    {
        if (this.direction.sqrMagnitude != 0) //sqrMagnitude > 0 then we are moving in some direction
        {
            this.rigidbody.AddForce(this.direction * this.speed); //Adding force to rigid body 
        }
    }

}