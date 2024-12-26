using UnityEngine;

public class CatcherMovement : MonoBehaviour
{
    public float speed = 10f; // Speed of the catcher

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal"); // Get input (left/right arrow keys)
        Vector3 movement = new Vector3(horizontal, 0, 0); // Movement vector
        transform.Translate(movement * speed * Time.deltaTime); // Move the catcher
    }
}
