using UnityEngine;
using TMPro;

public class TotalTimeCounter3 : MonoBehaviour // Counting the player's total time on the track (TRACK 3) [Script almost same as the laps timer script]
{
    // What the timer will count
    public static int totalMinutesCounter3;
    public static int totalSecondsCounter3;
    public static float totalMillisecondsCounter3;
    public static string displayTotalMilliseconds3;

    // Where they will be placed in the game's UI
    public GameObject totalMinutesPosition3;
    public GameObject totalSecondsPositions3;
    public GameObject totalMillisecondsPositions3;

    public static float realTime3; // Game's current real time

    void Update()
    {
        totalMillisecondsCounter3 += Time.deltaTime * 10;
        realTime3 += Time.deltaTime;
        displayTotalMilliseconds3 = totalMillisecondsCounter3.ToString("0");
        totalMillisecondsPositions3.GetComponent<TMP_Text>().text = "" + displayTotalMilliseconds3;

        // Setting the limits on what and how to show (+on UI) each part of the total timer
        if (totalMillisecondsCounter3 >= 10) // For the milliseconds of the total timer
        {
            totalMillisecondsCounter3 = 0;
            totalSecondsCounter3 += 1;
        }

        if (totalSecondsCounter3 <= 9) // For the seconds of the total timer
        {
            totalSecondsPositions3.GetComponent<TMP_Text>().text = "0" + totalSecondsCounter3 + ".";
        }
        else
        {
            totalSecondsPositions3.GetComponent<TMP_Text>().text = "" + totalSecondsCounter3 + ".";
        }
        if (totalSecondsCounter3 >= 60)
        {
            totalSecondsCounter3 = 0;
            totalMinutesCounter3 += 1;
        }

        if (totalMinutesCounter3 <= 9) // For the minutes of the total timer
        {
            totalMinutesPosition3.GetComponent<TMP_Text>().text = "" + totalMinutesCounter3 + ":";
        }
        else
        {
            totalMinutesPosition3.GetComponent<TMP_Text>().text = "" + totalMinutesCounter3 + ":";
        }
    }
}