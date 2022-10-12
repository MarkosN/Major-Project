using UnityEngine;
using TMPro;

public class SaveLapTimeMultiplayerII : MonoBehaviour //  The best lap time for PLAYER 2 will be saved and will be viewed as the best one (TRACK 1) - Multiplayer
{
    // The "lap" numbers that the lap's time counter will contain
    public int minutesCounter;
    public int secondsCounter;
    public float millisecondsCounter;

    // Connect this with the UI texts
    public GameObject displayMinutes;
    public GameObject displaySeconds;
    public GameObject displayMilliseconds;

    void Start()
    {
        // Keeping the best lap time
        minutesCounter = PlayerPrefs.GetInt("MinSaveMultiplayerII");
        secondsCounter = PlayerPrefs.GetInt("SecSaveMultiplayerII");
        millisecondsCounter = PlayerPrefs.GetFloat("MilliSaveMultiplayerII");

        // Display the best lap time
        displayMinutes.GetComponent<TMP_Text>().text = "" + minutesCounter + ":";
        displaySeconds.GetComponent<TMP_Text>().text = "" + secondsCounter + ".";
        displayMilliseconds.GetComponent<TMP_Text>().text = "" + ((int)millisecondsCounter).ToString(); // Casting it to int only for UI purposes
    }
}