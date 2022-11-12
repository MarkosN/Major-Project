using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaceFinish2 : MonoBehaviour // For Player 2 Only
{
    public GameObject raceFinishSequencePlayer2; // Enable the finish racing sequence for player 2 if they reach the end first
    public GameObject finishRacePlayer1; // Delete the race finish (not racing sequence) for player 1 if the player 2 has completed the race

    public GameObject cameraViewScenario2; // Camera View for Car 2 Scenario

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player2")
        {
            raceFinishSequencePlayer2.SetActive(true);
            Destroy(finishRacePlayer1);
            StartCoroutine(CameraViewScenario());
        }
    }

    IEnumerator CameraViewScenario() // Enabling the scenario
    {
        yield return new WaitForSeconds(0.1f);
        cameraViewScenario2.SetActive(true);
    }
}