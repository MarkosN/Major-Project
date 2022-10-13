using UnityEngine;
using TMPro;

public class SaveLatestLapTimeIII : MonoBehaviour //  The latest lap time will be saved and will be viewed by the player (TRACK 2)
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
        minutesCounter = PlayerPrefs.GetInt("MinSave2");
        secondsCounter = PlayerPrefs.GetInt("SecSave2");
        millisecondsCounter = PlayerPrefs.GetFloat("MilliSave2");

        // Display the best lap time
        displayMinutes.GetComponent<TMP_Text>().text = "" + minutesCounter + ":";
        displaySeconds.GetComponent<TMP_Text>().text = "" + secondsCounter + ".";
        displayMilliseconds.GetComponent<TMP_Text>().text = "" + ((int)millisecondsCounter).ToString(); // Casting it to int only for UI purposes
    }
}