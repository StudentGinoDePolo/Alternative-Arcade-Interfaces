using UnityEngine;
using UnityEngine.UI; //UI engine library for scoring elements

public class GameManager : MonoBehaviour
{
    public Ball ball;

    public Paddle playerPaddle;
    public int playerScore { get; private set; }
    public Text playerScoreText;

    public Paddle computerPaddle;
    public int computerScore { get; private set; }
    public Text computerScoreText;

    private void Start()
    {
       // LockPlayerCursor();
    }

    private void Update()
    {
        LockPlayerCursor();
        UnlockPlayerCursor();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            NewGame();
        }

    }

    public void NewGame()
    {
            SetPlayerScore(0);
            SetComputerScore(0);
            StartRound();
    }

    public void StartRound()
    {

        this.playerPaddle.ResetPosition();
        this.computerPaddle.ResetPosition();
        this.ball.ResetPosition();
        this.ball.AddStartingForce();
    }

    public void PlayerScores() //Increase score when player scores
    {
        SetPlayerScore(this.playerScore + 1);
        StartRound();
    }

    public void ComputerScores() //Increase computer score when computer scores
    {
        SetComputerScore(this.computerScore + 1);
        StartRound();
    }

    private void SetPlayerScore(int score) //Keep track of player score
    {
        this.playerScore = score;
        this.playerScoreText.text = score.ToString();
    }

    private void SetComputerScore(int score) //Keep track of computer score
    {
        this.computerScore = score;
        this.computerScoreText.text = score.ToString();
    }

    public void LockPlayerCursor()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            Cursor.lockState = CursorLockMode.Locked;

        }
    }

    public void UnlockPlayerCursor()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;
        }
    }

}