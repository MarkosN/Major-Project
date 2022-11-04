using UnityEngine;

public class PauseMenu : MonoBehaviour // The pause menu of the game
{
    public static bool gamePaused = false; // Starting without the game being paused

    public GameObject pauseMenu; //  The pause menu UI
    public GameObject[] disableParts; // Disable specific parts when the game is paused

    public GameObject enableMainSection; // Enabling this happens in order for everytime that the players open the Pause menu they will be able to access it from the main section of it
    public GameObject disableSettingsSection; // Disabling this happens in order for everytime that the players open the Pause menu they will be able to access it from the main section of it

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.P)) // When ESC or P keys are pressed the game will pause - If the game is already paused then it will Resume
        {
            if (gamePaused)
            {
                ResumeGame();
                disableSettingsSection.SetActive(false);
                enableMainSection.SetActive(true);
            }
            else
            {
                PauseGame();
                gamePaused = true;
                disableSettingsSection.SetActive(false);
                enableMainSection.SetActive(true);
            }
        }
    }

    public void PauseGame()
    {
        // Enable the pause menu main components (UI etc.)
        pauseMenu.SetActive(true);
        gamePaused = true;

        Time.timeScale = 0f; // 0f - Paused

        // Unlock and make visible the Cursor of the mouse
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;

        // Disable the extra things from the game that might be affected by the pause menu
        for (int i = 0; i < disableParts.Length; i++)
        {
            disableParts[i].SetActive(false);
        }
    }

    public void ResumeGame()
    {
        // Disable the pause menu main components (UI etc.)
        pauseMenu.SetActive(false);
        gamePaused = false;

        Time.timeScale = 1f; // 1f - Normal Time
        
        // Lock and make not visible the Cursor of the mouse
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        // Enable the extra things from the game that didn't want to be affected by the pause menu
        for (int i = 0; i < disableParts.Length; i++)
        {
            disableParts[i].SetActive(true);
        }
    }
}