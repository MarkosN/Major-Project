using UnityEngine;
using TMPro;

public class SaveLapTime : MonoBehaviour //  The best lap time will be saved and will be viewed as the best one
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
        minutesCounter = PlayerPrefs.GetInt("MinSave");
        secondsCounter = PlayerPrefs.GetInt("SecSave");
        millisecondsCounter = PlayerPrefs.GetFloat("MilliSave");

        // Display the best lap time
        displayMinutes.GetComponent<TMP_Text>().text = "" + minutesCounter + ":";
        displaySeconds.GetComponent<TMP_Text>().text = "" + secondsCounter + ".";
        displayMilliseconds.GetComponent<TMP_Text>().text = "" + millisecondsCounter;
    }
}