using UnityEngine;
using UnityEngine.Events; //importing Unity Library

[RequireComponent(typeof(BoxCollider2D))]
public class ScoringZone : MonoBehaviour
{
    public UnityEvent scoreTrigger; //Unity scoring trigger

    private void OnCollisionEnter2D(Collision2D collision) //Upon collision
    {
        Ball ball = collision.gameObject.GetComponent<Ball>();

        if (ball != null)
        {
            this.scoreTrigger.Invoke(); //invoke trigger event (Score)
        }
    }

}
