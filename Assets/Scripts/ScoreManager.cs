using UnityEngine;
using TMPro;  // For TextMesh Pro (replace with UI Text if needed)

public class ScoreManager : MonoBehaviour
{
    public TMP_Text scoreText;  // Reference to the UI text for the score
    private int score = 0;  // Start the score at 0

    void Start()
    {
        UpdateScore();  // Update the score display when the game starts
    }

    // Function to increase the score
    public void AddScore(int points)
    {
        score += points;
        UpdateScore();  // Update the score display after adding points
    }

    // Update the score UI
    private void UpdateScore()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score;
        }
    }

    // Function to check if the player has won (if you have a specific score to win)
    public bool HasWon(int winScore)
    {
        return score >= winScore;
    }

    public int GetScore()
    {
        return score;
    }
}



/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // For handling UI elements

public class ScoreManager : MonoBehaviour
{
    public TMP_Text scoreText; // Reference to the UI Text
    private int score = -5; // Initial score

    void Start()
    {
        UpdateScore(); // Display the initial score
    }

    // Function to increase the score
    public void AddScore(int points)
    {
        score += points;
        UpdateScore();
    }

    // Update the score display on the UI
    private void UpdateScore()
    {
        scoreText.text = "Score: " + score;
    }
}

*/