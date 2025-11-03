using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    public static GameController instance;

    [Header("UI References")]
    public TextMeshProUGUI scoreTextLeft;
    public TextMeshProUGUI scoreTextRight;
    public TextMeshProUGUI winText;
    public GameObject winPanel; // <-- Your Win Panel

    [Header("Game Settings")]
    public int winningScore = 5; // Can be set from Inspector

    private int scoreLeft = 0;
    private int scoreRight = 0;
    private bool gameEnded = false;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        UpdateScoreText();

        if (winPanel != null)
            winPanel.SetActive(false); // Hide the panel at start
    }

    public void AddScoreLeft()
    {
        if (gameEnded) return;
        scoreLeft++;
        UpdateScoreText();
        CheckWinner();
    }

    public void AddScoreRight()
    {
        if (gameEnded) return;
        scoreRight++;
        UpdateScoreText();
        CheckWinner();
    }

    private void UpdateScoreText()
    {
        if (scoreTextLeft != null)
            scoreTextLeft.text = scoreLeft.ToString();

        if (scoreTextRight != null)
            scoreTextRight.text = scoreRight.ToString();
    }

    private void CheckWinner()
    {
        if (scoreLeft >= winningScore)
            EndGame(GetRandomWinMessage(true));
        else if (scoreRight >= winningScore)
            EndGame(GetRandomWinMessage(false));
    }

    private void EndGame(string message)
    {
        gameEnded = true;

        if (winPanel != null)
            winPanel.SetActive(true); // Show panel on win

        if (winText != null)
            winText.text = message;

        // Stop the ball
        BallController ball = FindObjectOfType<BallController>();
        if (ball != null)
        {
            Rigidbody rb = ball.GetComponent<Rigidbody>();
            if (rb != null)
                rb.linearVelocity = Vector3.zero;

            ball.enabled = false;
        }

        Debug.Log(message);
    }

    public void StartGame()
    {
        gameEnded = false;
        scoreLeft = 0;
        scoreRight = 0;
        UpdateScoreText();

        if (winPanel != null)
            winPanel.SetActive(false); // Hide panel on restart

        if (winText != null)
            winText.text = "";

        BallController ball = FindObjectOfType<BallController>();
        if (ball != null)
            ball.enabled = true;
    }

    private string GetRandomWinMessage(bool isLeft)
    {
        string player = isLeft ? "LEFT PLAYER" : "RIGHT PLAYER";

        string[] messages =
        {
            $"CONGRATULATIONS! {player} WINS THE MATCH!",
            $"EXCELLENT PLAY! {player} DOMINATES THE GAME!",
            $"UNSTOPPABLE! {player} TAKES THE VICTORY!",
            $"BRILLIANT PERFORMANCE! {player} TRIUMPHS!",
            $"AMAZING! {player} CLAIMS THE CHAMPIONSHIP!"
        };

        return messages[Random.Range(0, messages.Length)];
    }
}
