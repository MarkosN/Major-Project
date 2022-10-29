using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsManager : MonoBehaviour
{
    public void ReturnToMainMenu() // Button to Give the Player the Ability to Return to Main Menu
    {
        SceneManager.LoadScene("MainMenu");
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