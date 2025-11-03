using UnityEngine;

public class Starter : MonoBehaviour
{
    private GameController gameController;
    private Animator animator;

    void Start()
    {
        gameController = FindFirstObjectByType<GameController>();
        animator = GetComponent<Animator>();
    }

    // Called by GameController to begin countdown
    public void StartCountdown()
    {
        if (animator != null)
            animator.SetTrigger("StartCountdown");
    }

    // Animation event calls this when countdown ends
    public void StartGame()
    {
        if (gameController != null)
            gameController.StartGame();
    }
}
