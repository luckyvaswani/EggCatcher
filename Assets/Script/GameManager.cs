using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public UnityEngine.UI.Text scoreText; // Explicitly specify UnityEngine.UI.Text
    public UnityEngine.UI.Text livesText; // Explicitly specify UnityEngine.UI.Text

    private int score = 0; // Player's score
    private int lives = 3; // Player's lives

    void Start()
    {
        UnityEngine.Debug.Log("GameManager initialized.");
    }

    // Add score
    public void AddScore(int value)
    {
        score += value; // Increase the score
        scoreText.text = "Score: " + score; // Update the score UI
        UnityEngine.Debug.Log("Score updated to: " + score); // Debug log
    }

    // Deduct lives
    public void LoseLife(int value)
    {
        lives -= value; // Decrease lives
        livesText.text = "Lives: " + lives; // Update the lives UI
        UnityEngine.Debug.Log("Lives updated to: " + lives); // Debug log

        if (lives <= 0)
        {
            GameOver(); // Trigger game over when lives run out
        }
    }

    // Game over logic
    private void GameOver()
    {
        UnityEngine.Debug.Log("Game Over!"); // Explicitly use UnityEngine.Debug
        // Optionally, show a game over screen or restart the game
    }
}
