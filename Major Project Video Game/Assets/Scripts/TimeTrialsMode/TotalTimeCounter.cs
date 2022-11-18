using UnityEngine;
using TMPro;

public class TotalTimeCounter : MonoBehaviour // Counting the player's total time on the track (TRACK 1) [Script almost same as the laps timer script]
{
    // What the timer will count
    public static int totalMinutesCounter;
    public static int totalSecondsCounter;
    public static float totalMillisecondsCounter;
    public static string displayTotalMilliseconds;

    // Where they will be placed in the game's UI
    public GameObject totalMinutesPosition;
    public GameObject totalSecondsPositions;
    public GameObject totalMillisecondsPositions;

    public static float realTime; // Game's current real time

    void Update()
    {
        totalMillisecondsCounter += Time.deltaTime * 10;
        realTime += Time.deltaTime;
        displayTotalMilliseconds = totalMillisecondsCounter.ToString("0");
        totalMillisecondsPositions.GetComponent<TMP_Text>().text = "" + displayTotalMilliseconds;

        // Setting the limits on what and how to show (+on UI) each part of the total timer
        if (totalMillisecondsCounter >= 10) // For the milliseconds of the total timer
        {
            totalMillisecondsCounter = 0;
            totalSecondsCounter += 1;
        }

        if (totalSecondsCounter <= 9) // For the seconds of the total timer
        {
            totalSecondsPositions.GetComponent<TMP_Text>().text = "0" + totalSecondsCounter + ".";
        }
        else
        {
            totalSecondsPositions.GetComponent<TMP_Text>().text = "" + totalSecondsCounter + ".";
        }
        if (totalSecondsCounter >= 60)
        {
            totalSecondsCounter = 0;
            totalMinutesCounter += 1;
        }

        if (totalMinutesCounter <= 9) // For the minutes of the total timer
        {
            totalMinutesPosition.GetComponent<TMP_Text>().text = "" + totalMinutesCounter + ":";
        }
        else
        {
            totalMinutesPosition.GetComponent<TMP_Text>().text = "" + totalMinutesCounter + ":";
        }
    }
}