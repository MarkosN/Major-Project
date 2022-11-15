using System.Collections;
using UnityEngine;

public class LapsTrackerMultiplayer : MonoBehaviour // Tracking the laps that the PLAYER 2 has complete - Multiplayer
{
    public GameObject fullLapComplete; // When the player passes and completes a full lap
    public GameObject halfLapComplete; // When the player passes and completes a a half of a lap

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player2")
        {
            fullLapComplete.SetActive(true);  // Full lap trigger box
            halfLapComplete.SetActive(false); // Half lap trigger box
        }
    }
}