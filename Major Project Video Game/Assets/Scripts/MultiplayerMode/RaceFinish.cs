using System.Collections;
using UnityEngine;

public class RaceFinish : MonoBehaviour // For Player 1 Only
{
    public GameObject raceFinishSequencePlayer1; // Enable the finish racing sequence for player 1 if they reach the end first
    public GameObject finishRacePlayer2; // Delete the race finish (not racing sequence) for player 2 if the player 1 has completed the race

    public GameObject cameraViewScenario1; // Camera View for Car 1 Scenario
    public GameObject newAutomatedCameraSystem1; // By disabling the main manager of the camera views (scenarios) for an X amount of time it will help by not changing the cameras views continuously creating problems to the players
    public GameObject cameraViewScenario2; // Camera View for Car 2 Scenario
    public GameObject newAutomatedCameraSystem2; // By disabling the main manager of the camera views (scenarios) for an X amount of time it will help by not changing the cameras views continuously creating problems to the players

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            raceFinishSequencePlayer1.SetActive(true);
            Destroy(finishRacePlayer2);
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
        cameraViewScenario1.SetActive(true);
        cameraViewScenario2.SetActive(true);
        yield return new WaitForSeconds(4.9f);
        cameraViewScenario1.SetActive(false);
        cameraViewScenario2.SetActive(false);
    }

    IEnumerator CameraViewScenario2()
    {
        yield return new WaitForSeconds(0.2f);
        newAutomatedCameraSystem1.SetActive(false);
        newAutomatedCameraSystem2.SetActive(false);
        yield return new WaitForSeconds(4.8f);
        newAutomatedCameraSystem1.SetActive(true);
        newAutomatedCameraSystem2.SetActive(true);
    }
}