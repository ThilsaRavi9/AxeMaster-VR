using UnityEngine;
using UnityEngine.SceneManagement;  // For reloading scenes
using TMPro;  // For TextMesh Pro (replace with UI Text if using default UI Text)

public class GameController : MonoBehaviour
{
    public TMP_Text winText;  // Reference to the TextMeshPro text (use UI Text if needed)

    void Start()
    {
        // Ensure the win message is hidden at the start
        if (winText != null)
        {
            winText.gameObject.SetActive(false);
        }
    }

    // Function to display the win message
    public void ShowWinMessage()
    {
        if (winText != null)
        {
            winText.gameObject.SetActive(true);  // Display the "You Won" text
            winText.text = "You Won!";
            Time.timeScale = 0f;  // Freeze the game
        }
    }

    // Function to reset the game
    public void ResetGame()
    {
        Time.timeScale = 1f;  // Unfreeze the game
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);  // Reload the current scene
    }
}
