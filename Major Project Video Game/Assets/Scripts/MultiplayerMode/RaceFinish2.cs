using System.Collections;
using UnityEngine;

public class RaceFinish2 : MonoBehaviour // For Player 2 Only
{
    public GameObject raceFinishSequencePlayer2; // Enable the finish racing sequence for player 2 if they reach the end first
    public GameObject finishRacePlayer1; // Delete the race finish (not racing sequence) for player 1 if the player 2 has completed the race

    public GameObject cameraViewScenario2; // Camera View for Car 2 Scenario
    public GameObject newAutomatedCameraSystem2; // By disabling the main manager of the camera views (scenarios) for an X amount of time it will help by not changing the cameras views continuously creating problems to the players
    public GameObject cameraViewScenario1; // Camera View for Car 1 Scenario
    public GameObject newAutomatedCameraSystem1; // By disabling the main manager of the camera views (scenarios) for an X amount of time it will help by not changing the cameras views continuously creating problems to the players

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player2")
        {
            raceFinishSequencePlayer2.SetActive(true);
            Destroy(finishRacePlayer1);
            StartCoroutine(CameraViewScenario());
            StartCoroutine(CameraViewScenario2());

            //Lap Time Counter Reset (Split_Screen Multiplayer Mode)
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
    }

    IEnumerator CameraViewScenario() // Enabling the scenario
    {
        yield return new WaitForSeconds(0.1f);
        cameraViewScenario2.SetActive(true);
        cameraViewScenario1.SetActive(true);
        yield return new WaitForSeconds(4.9f);
        cameraViewScenario2.SetActive(false);
        cameraViewScenario1.SetActive(false);
    }

    IEnumerator CameraViewScenario2()
    {
        yield return new WaitForSeconds(0.2f);
        newAutomatedCameraSystem2.SetActive(false);
        newAutomatedCameraSystem1.SetActive(false);
        yield return new WaitForSeconds(4.8f);
        newAutomatedCameraSystem2.SetActive(true);
        newAutomatedCameraSystem1.SetActive(true);
    }
}