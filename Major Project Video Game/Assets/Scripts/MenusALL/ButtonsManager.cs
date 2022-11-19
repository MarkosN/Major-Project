using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsManager : MonoBehaviour
{
    public void ReturnToMainMenu() // Button to Give the Player the Ability to Return to Main Menu (via the Loading Scene)
    {
        Time.timeScale = 1f; // 1f - Normal Time
        SceneManager.LoadScene("LoadingScene");

        // Resetting the times on the laps (except the one which are intentionally saved)
        //Total Time Counters (Time Trials Mode)
        TotalTimeCounter.totalMinutesCounter = 0;
        TotalTimeCounter.totalSecondsCounter = 0;
        TotalTimeCounter.totalMillisecondsCounter = 0;
        TotalTimeCounter2.totalMinutesCounter2 = 0;
        TotalTimeCounter2.totalSecondsCounter2 = 0;
        TotalTimeCounter2.totalMillisecondsCounter2 = 0;
        TotalTimeCounter3.totalMinutesCounter3 = 0;
        TotalTimeCounter3.totalSecondsCounter3 = 0;
        TotalTimeCounter3.totalMillisecondsCounter3 = 0;
        //Lap Time Counter (Time Trials Mode)
        LapsTimer.minutesCounter_ = 0;
        LapsTimer.secondsCounter_ = 0;
        LapsTimer.millisecondsCounter_ = 0;
        LapsTimerII.minutesCounter_ = 0;
        LapsTimerII.secondsCounter_ = 0;
        LapsTimerII.millisecondsCounter_ = 0;
        LapsTimerIII.minutesCounter_ = 0;
        LapsTimerIII.secondsCounter_ = 0;
        LapsTimerIII.millisecondsCounter_ = 0;
        //Lap Time Counter (Split_Screen Multiplayer Mode)
        LapsTimerMultiplayer.minutesCounter_ = 0;
        LapsTimerMultiplayer.secondsCounter_ = 0;
        LapsTimerMultiplayer.millisecondsCounter_ = 0;
        LapsTimerMultiplayerII.minutesCounter_ = 0;
        LapsTimerMultiplayerII.secondsCounter_ = 0;
        LapsTimerMultiplayerII.millisecondsCounter_ = 0;
        LapsTimerMultiplayerIII.minutesCounter_ = 0;
        LapsTimerMultiplayerIII.secondsCounter_ = 0;
        LapsTimerMultiplayerIII.millisecondsCounter_ = 0;
    }

    public void ResumeGame() // Close the pause menu and resume the game
    {
        Time.timeScale = 1f; // 1f - Normal Time

        // Lock and make not visible the Cursor of the mouse
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void RestartMode() //  Restart the Racing Mode
    {
        Time.timeScale = 1f; // 1f - Normal Time
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        // Resetting the times on the laps (except the one which are intentionally saved)
        //Total Time Counters (Time Trials Mode)
        TotalTimeCounter.totalMinutesCounter = 0;
        TotalTimeCounter.totalSecondsCounter = 0;
        TotalTimeCounter.totalMillisecondsCounter = 0;
        TotalTimeCounter2.totalMinutesCounter2 = 0;
        TotalTimeCounter2.totalSecondsCounter2 = 0;
        TotalTimeCounter2.totalMillisecondsCounter2 = 0;
        TotalTimeCounter3.totalMinutesCounter3 = 0;
        TotalTimeCounter3.totalSecondsCounter3 = 0;
        TotalTimeCounter3.totalMillisecondsCounter3 = 0;
        //Lap Time Counter (Time Trials Mode)
        LapsTimer.minutesCounter_ = 0;
        LapsTimer.secondsCounter_ = 0;
        LapsTimer.millisecondsCounter_ = 0;
        LapsTimerII.minutesCounter_ = 0;
        LapsTimerII.secondsCounter_ = 0;
        LapsTimerII.millisecondsCounter_ = 0;
        LapsTimerIII.minutesCounter_ = 0;
        LapsTimerIII.secondsCounter_ = 0;
        LapsTimerIII.millisecondsCounter_ = 0;
        //Lap Time Counter (Split_Screen Multiplayer Mode)
        LapsTimerMultiplayer.minutesCounter_ = 0;
        LapsTimerMultiplayer.secondsCounter_ = 0;
        LapsTimerMultiplayer.millisecondsCounter_ = 0;
        LapsTimerMultiplayerII.minutesCounter_ = 0;
        LapsTimerMultiplayerII.secondsCounter_ = 0;
        LapsTimerMultiplayerII.millisecondsCounter_ = 0;
        LapsTimerMultiplayerIII.minutesCounter_ = 0;
        LapsTimerMultiplayerIII.secondsCounter_ = 0;
        LapsTimerMultiplayerIII.millisecondsCounter_ = 0;
    }

    // Tracks (and Modes) Buttons that will give to the players access to them
    public void PracticeModeTrack()
    {
        SceneManager.LoadScene("Track0Practice");
    }
    public void TimeTrialsTrack1()
    {
        SceneManager.LoadScene("Track1TimeTrials");
    }
    public void TimeTrialsTrack2()
    {
        SceneManager.LoadScene("Track2TimeTrials");
    }
    public void TimeTrialsTrack3()
    {
        SceneManager.LoadScene("Track3TimeTrials");
    }
    public void MultiplayerTrack1()
    {
        SceneManager.LoadScene("Track1Multiplayer");
    }
    public void MultiplayerTrack2()
    {
        SceneManager.LoadScene("Track2Multiplayer");
    }
    public void MultiplayerTrack3()
    {
        SceneManager.LoadScene("Track3Multiplayer");
    }

    public void Exit() // Button to Give the Player the Ability to Exit the Game
    {
        Application.Quit();
    }
}