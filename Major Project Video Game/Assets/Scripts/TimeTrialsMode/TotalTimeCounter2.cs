using UnityEngine;
using TMPro;

public class TotalTimeCounter2 : MonoBehaviour // Counting the player's total time on the track (TRACK 2) [Script almost same as the laps timer script]
{
    // What the timer will count
    public static int totalMinutesCounter2;
    public static int totalSecondsCounter2;
    public static float totalMillisecondsCounter2;
    public static string displayTotalMilliseconds2;

    // Where they will be placed in the game's UI
    public GameObject totalMinutesPosition2;
    public GameObject totalSecondsPositions2;
    public GameObject totalMillisecondsPositions2;

    public static float realTime2; // Game's current real time

    void Update()
    {
        totalMillisecondsCounter2 += Time.deltaTime * 10;
        realTime2 += Time.deltaTime;
        displayTotalMilliseconds2 = totalMillisecondsCounter2.ToString("0");
        totalMillisecondsPositions2.GetComponent<TMP_Text>().text = "" + displayTotalMilliseconds2;

        // Setting the limits on what and how to show (+on UI) each part of the total timer
        if (totalMillisecondsCounter2 >= 10) // For the milliseconds of the total timer
        {
            totalMillisecondsCounter2 = 0;
            totalSecondsCounter2 += 1;
        }

        if (totalSecondsCounter2 <= 9) // For the seconds of the total timer
        {
            totalSecondsPositions2.GetComponent<TMP_Text>().text = "0" + totalSecondsCounter2 + ".";
        }
        else
        {
            totalSecondsPositions2.GetComponent<TMP_Text>().text = "" + totalSecondsCounter2 + ".";
        }
        if (totalSecondsCounter2 >= 60)
        {
            totalSecondsCounter2 = 0;
            totalMinutesCounter2 += 1;
        }

        if (totalMinutesCounter2 <= 9) // For the minutes of the total timer
        {
            totalMinutesPosition2.GetComponent<TMP_Text>().text = "" + totalMinutesCounter2 + ":";
        }
        else
        {
            totalMinutesPosition2.GetComponent<TMP_Text>().text = "" + totalMinutesCounter2 + ":";
        }
    }
}