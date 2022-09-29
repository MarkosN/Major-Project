using UnityEngine;

public class LapsTracker : MonoBehaviour // Tracking the laps that the player has complete
{
    public GameObject fullLapComplete; // When the player passes and completes a full lap
    public GameObject halfLapComplete; // When the player passes and completes a a half of a lap

    void OnTriggerEnter()
    {
        fullLapComplete.SetActive(true);  // Full lap trigger box
        halfLapComplete.SetActive(false); // Half lap trigger box
    }
}