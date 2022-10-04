using UnityEngine;
using TMPro;

public class SaveLapTimeII : MonoBehaviour //  The best lap time will be saved and will be viewed as the best one (TRACK 1)
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
        minutesCounter = PlayerPrefs.GetInt("MinSave1");
        secondsCounter = PlayerPrefs.GetInt("SecSave1");
        millisecondsCounter = PlayerPrefs.GetFloat("MilliSave1");

        // Display the best lap time
        displayMinutes.GetComponent<TMP_Text>().text = "" + minutesCounter + ":";
        displaySeconds.GetComponent<TMP_Text>().text = "" + secondsCounter + ".";
        displayMilliseconds.GetComponent<TMP_Text>().text = "" + ((int)millisecondsCounter).ToString(); // Casting it to int only for UI purposes
    }
}