using System.Collections;
using UnityEngine;

public class LapsTrackerMultiplayer : MonoBehaviour // Tracking the laps that the PLAYER 2 has complete - Multiplayer
{
    public GameObject fullLapComplete; // When the player passes and completes a full lap
    public GameObject halfLapComplete; // When the player passes and completes a a half of a lap

    public GameObject cameraViewScenario2; // Camera View for Car 2 Scenario

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player2")
        {
            fullLapComplete.SetActive(true);  // Full lap trigger box
            halfLapComplete.SetActive(false); // Half lap trigger box
            StartCoroutine(CameraViewScenario());
        }
    }

    IEnumerator CameraViewScenario() // Enabling the scenario and then diasbling so it won't overlap with the other
    {
        yield return new WaitForSeconds(0.1f);
        cameraViewScenario2.SetActive(true);
        yield return new WaitForSeconds(10.0f);
        cameraViewScenario2.SetActive(false);
    }
}