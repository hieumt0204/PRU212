using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{
    private bool isPaused = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) // You can change the key to any other you prefer
        {
            if (isPaused)
                ResumeGame();
            else
                Pause();
        }
    }

    public void Pause()
    {
        Time.timeScale = 0f; // Pause the game
        isPaused = true;
        // Add any other pause-related functionality here (e.g., displaying pause menu)
    }

    public void ResumeGame()
    {
        Time.timeScale = 1f; // Resume the game
        isPaused = false;
        // Add any other resume-related functionality here (e.g., hiding pause menu)
    }
}
