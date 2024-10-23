using UnityEngine;

public class AxeScript : MonoBehaviour
{
    private ScoreManager scoreManager;
    public GameController gameController;
    public int winScore = 40;

    void Start()
    {
        // Find the ScoreManager and GameController
        scoreManager = FindObjectOfType<ScoreManager>();
        gameController = FindObjectOfType<GameController>();
    }

    void OnCollisionEnter(Collision collision)
    {
        // Debug to see what the axe is hitting
        Debug.Log("Axe collided with: " + collision.gameObject.name + " (Tag: " + collision.gameObject.tag + ")");

        bool hitTarget = false;  // Flag to check if we hit a target

        // Check if the object has the "Tiger" tag
        if (collision.gameObject.CompareTag("Tiger"))
        {
            // Debug to confirm that the tag is correct
            Debug.Log("Hit the target!");

            // Destroy the target object
            Destroy(collision.gameObject);

            // Add score for hitting the target
            scoreManager.AddScore(10);
            hitTarget = true;  // Set the hit flag
        }
        else if (collision.gameObject.CompareTag("Horse"))
        {
            // Debug to confirm that the tag is correct
            Debug.Log("Hit the target!");

            // Destroy the target object
            Destroy(collision.gameObject);

            // Add score for hitting the target
            scoreManager.AddScore(15);
            hitTarget = true;  // Set the hit flag
        }
        else if (collision.gameObject.CompareTag("15")) // Assuming this is another target type
        {
            // Debug to confirm that the tag is correct
            Debug.Log("Hit the target!");

            // Destroy the target object
            Destroy(collision.gameObject);

            // Add score for hitting the target
            scoreManager.AddScore(10);
            hitTarget = true;  // Set the hit flag
        }

        if (hitTarget)  // Check if a target was hit
        {
            // Check for winning condition
            if (scoreManager.GetScore() >= winScore)
            {
                gameController.ShowWinMessage();  // Show the "You Won!" message
            }
        }
        else
        {
            // If it's not a target, debug what was hit
            Debug.Log("Collided with non-target object: " + collision.gameObject.tag);
        }
    }
}



/*
using UnityEngine;

public class AxeScript : MonoBehaviour
{
    private ScoreManager scoreManager;
    public GameController gameController;
    public int winScore = 30;  // Define the score needed to win the game

    void Start()
    {
        // Get the ScoreManager and GameController in the scene
        scoreManager = FindObjectOfType<ScoreManager>();
        gameController = FindObjectOfType<GameController>();
    }

    void OnCollisionEnter(Collision collision)
    {
        // Check if the axe collides with the ground (or other target objects)
        if (collision.gameObject.CompareTag("Plane"))
        {
            scoreManager.AddScore(10);  // Increase score by 10 points for each valid collision
        }

        // Check if the player has won
        if (scoreManager.GetScore() >= winScore)
        {
            gameController.ShowWinMessage();  // Show the "You Won!" message
        }
    }
}
*/

/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxeScript : MonoBehaviour
{
    private ScoreManager scoreManager;
    public GameObject Cube;

    void Start()
    {
        scoreManager = FindObjectOfType<ScoreManager>(); // Get reference to ScoreManager
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Plane"))
        {
            scoreManager.AddScore(10);
        }

        if(scoreManager==30)
        {
            ShowWinMessage();
        } 
    
        
    }


}
*/
