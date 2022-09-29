using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LapsManager : MonoBehaviour // Managing when a lap is complete, when the race is over and the lap's timer.
{
    // Tracking when a full or half lap has been complete
    public GameObject fullLapTrigger;
    public GameObject halfLapTrigger;

    // Display the (current) lap timer parts
    public GameObject displayMinutes_;
    public GameObject displaySeconds_;
    public GameObject displayMilliseconds_;

    // The number fo the laps that will have and need to be completed
    public GameObject lapsNumberCounter;
    public int lapsNumber;

    public float realTime; // Game's current real time

    public GameObject raceComplete;

    void Update()
    {
        if (lapsNumber == 3)
        {
            raceComplete.SetActive(true); // Finishing race sequence
        }
    }

    void OnTriggerEnter()
    {
        // Adding a complete lap after the player has done one
        lapsNumber += 1;

        realTime = PlayerPrefs.GetFloat("realTime");

        if (LapsTimer.realTime <= realTime) // Lap's (current) Timer (what and how it will show)
        {
            if (LapsTimer.secondsCounter_ <= 9) // Timer's seconds
            {
                displaySeconds_.GetComponent<TMP_Text>().text = "0" + LapsTimer.secondsCounter_ + ".";
            }
            else
            {
                displaySeconds_.GetComponent<TMP_Text>().text = "" + LapsTimer.secondsCounter_ + ".";
            }

            if (LapsTimer.minutesCounter_ <= 9) // Timer's minutes
            {
                displayMinutes_.GetComponent<TMP_Text>().text = "" + LapsTimer.minutesCounter_ + ".";
            }
            else
            {
                displayMinutes_.GetComponent<TMP_Text>().text = "" + LapsTimer.minutesCounter_ + ".";
            }

            // Timer's milliseconds
            displayMilliseconds_.GetComponent<TMP_Text>().text = "" + LapsTimer.millisecondsCounter_;
        }

        // Saving the best lap time
        PlayerPrefs.SetInt("MinSave", LapsTimer.minutesCounter_);
        PlayerPrefs.SetInt("SecSave", LapsTimer.secondsCounter_);
        PlayerPrefs.SetFloat("MilliSave", LapsTimer.millisecondsCounter_);
        PlayerPrefs.SetFloat("realTime", LapsTimer.realTime);

        // From when the timer will start
        LapsTimer.minutesCounter_ = 0;
        LapsTimer.secondsCounter_ = 0;
        LapsTimer.millisecondsCounter_ = 0;
        LapsTimer.realTime = 0;

        // Laps' number that will be shown on the game's UI
        lapsNumberCounter.GetComponent<TMP_Text>().text = "" + lapsNumber;

        halfLapTrigger.SetActive(true);  // Half lap trigger box
        fullLapTrigger.SetActive(false); // Full lap trigger box
    }
}