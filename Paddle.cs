using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Paddle : MonoBehaviour
{
    public float speed = 12.0f; //Adjustable in Unity
    public new Rigidbody2D rigidbody { get; private set; } //Rigidbody movement force control of paddles

    private void Awake()
    {
        this.rigidbody = GetComponent<Rigidbody2D>();
    }

    public void ResetPosition()
    {
        this.rigidbody.velocity = Vector2.zero;
        this.rigidbody.position = new Vector2(this.rigidbody.position.x, 0.0f);
    }

}
