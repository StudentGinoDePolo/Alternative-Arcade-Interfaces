using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Ball : MonoBehaviour
{
    public float speed = 200.0f; //Value changed in Unity
    public new Rigidbody2D rigidbody { get; private set; } 

    private void Awake()
    {
        this.rigidbody = GetComponent<Rigidbody2D>(); //Searches for Rigidbody2D 
    }

    /*
    private void Start()
    {
        AddStartingForce();
    }
    */

    public void ResetPosition() //Reset position function - Used upon scoring
    {
        this.rigidbody.velocity = Vector2.zero;
        this.rigidbody.position = Vector2.zero;
    }

    public void AddStartingForce()
    {
        float x = Random.value < 0.5f ? -1.0f : 1.0f; // Determine if the ball starts left or right

        float y = Random.value < 0.5f ? Random.Range(-1.0f, -0.5f) 
                                      : Random.Range(0.5f, 1.0f); //determine if ball goes up or down. Range 0.5 -> 1.0 to ensure it does not move horizontal.

        Vector2 direction = new Vector2(x, y);
        this.rigidbody.AddForce(direction * this.speed); //Setting direction is only difference from player paddle (input)
    }

    public void AddForce(Vector2 force) //Adding force to ball called as needed based on the ball itself
    {
        this.rigidbody.AddForce(force);
    }

}