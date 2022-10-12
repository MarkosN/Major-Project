using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaceFinish : MonoBehaviour // For Player 1 Only
{
    public GameObject raceFinishSequencePlayer1; // Enable the finish racing sequence for player 1 if they reach the end first
    public GameObject finishRacePlayer2; // Delete the race finish (not racing sequence) for player 2 if the player 1 has completed the race

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            raceFinishSequencePlayer1.SetActive(true);
            Destroy(finishRacePlayer2);
        }
    }
}