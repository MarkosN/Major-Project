using UnityEngine;
using TMPro;

public class LapsTimerMultiplayerIII : MonoBehaviour // Count the PLAYER'S 2 current lap time real time (TRACK 2) - Multiplayer
{
    // What the timer will count
    public static int minutesCounter_;
    public static int secondsCounter_;
    public static float millisecondsCounter_;
    public static string displayMilliseconds_;

    // Where they will be placed in the game's UI
    public GameObject minutesPosition;
    public GameObject secondsPositions;
    public GameObject millisecondsPositions;

    public static float realTime; // Game's current real time

    void Update()
    {
        millisecondsCounter_ += Time.deltaTime * 10;
        realTime += Time.deltaTime;
        displayMilliseconds_ = millisecondsCounter_.ToString("0");
        millisecondsPositions.GetComponent<TMP_Text>().text = "" + displayMilliseconds_;

        // Setting the limits on what and how to show (+on UI) each part of the lap's time
        if (millisecondsCounter_ >= 10) // For the milliseconds of the lap's time
        {
            millisecondsCounter_ = 0;
            secondsCounter_ += 1;
        }

        if (secondsCounter_ <= 9) // For the seconds of the lap's time
        {
            secondsPositions.GetComponent<TMP_Text>().text = "0" + secondsCounter_ + ".";
        }
        else
        {
            secondsPositions.GetComponent<TMP_Text>().text = "" + secondsCounter_ + ".";
        }
        if (secondsCounter_ >= 60)
        {
            secondsCounter_ = 0;
            minutesCounter_ += 1;
        }

        if (minutesCounter_ <= 9) // For the minutes of the lap's time
        {
            minutesPosition.GetComponent<TMP_Text>().text = "" + minutesCounter_ + ":";
        }
        else
        {
            minutesPosition.GetComponent<TMP_Text>().text = "" + minutesCounter_ + ":";
        }
    }
}