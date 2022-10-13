using UnityEngine;
using TMPro;

public class SaveLatestLapTimeMultiplayer : MonoBehaviour //  The LATEST lap time for PLAYER 2 will be saved and will be viewed by the player (TRACK 3) - Multiplayer
{
    // The "lap" numbers that the lap's time counter will contain
    public int minutesCounter;
    public int secondsCounter;
    public float millisecondsCounter;

    // Connect this with the UI texts
    public GameObject displayMinutes;
    public GameObject displaySeconds;
    public GameObject displayMilliseconds;

    void Update()
    {
        // Keeping the best lap time
        minutesCounter = PlayerPrefs.GetInt("MinSaveMultiplayer");
        secondsCounter = PlayerPrefs.GetInt("SecSaveMultiplayer");
        millisecondsCounter = PlayerPrefs.GetFloat("MilliSaveMultiplayer");

        // Display the best lap time
        displayMinutes.GetComponent<TMP_Text>().text = "" + minutesCounter + ":";
        displaySeconds.GetComponent<TMP_Text>().text = "" + secondsCounter + ".";
        displayMilliseconds.GetComponent<TMP_Text>().text = "" + ((int)millisecondsCounter).ToString(); // Casting it to int only for UI purposes
    }
}