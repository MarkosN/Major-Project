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

    public void Exit() // Button to Give the Player the Ability to Exit the Game
    {
        Application.Quit();
    }
}