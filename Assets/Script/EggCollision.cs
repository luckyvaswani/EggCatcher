using UnityEngine;

public class EggCollision : MonoBehaviour
{
    private GameManager gameManager;

    private void Start()
    {
        gameManager = UnityEngine.Object.FindFirstObjectByType<GameManager>();
        if (gameManager == null)
        {
            UnityEngine.Debug.LogError("GameManager not found! Make sure a GameManager exists in the scene.");
        }
        else
        {
            UnityEngine.Debug.Log("GameManager reference successfully assigned.");
        }
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the egg collided with the catcher
        if (other.CompareTag("Catcher"))
        {
            UnityEngine.Debug.Log("Egg Caught!"); // Log when an egg is caught
            Destroy(gameObject); // Destroy the egg
            if (gameManager != null)
            {
                gameManager.AddScore(1); // Add to the score
            }
        }
        // Check if the egg collided with the ground
        else if (other.CompareTag("Ground"))
        {
            UnityEngine.Debug.Log("Egg Missed!"); // Log when an egg is missed
            Destroy(gameObject); // Destroy the egg
            if (gameManager != null)
            {
                gameManager.LoseLife(1); // Deduct a life
            }
        }
    }
}
