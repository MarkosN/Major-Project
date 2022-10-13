using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LapsManagerII : MonoBehaviour // Managing when a lap is complete, when the race is over and the lap's timer. (TRACK 1)
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
    public int lapsToComplete;

    public float realTime; // Game's current real time

    public GameObject raceComplete;

    void Update()
    {
        if (lapsNumber == lapsToComplete)
        {
            raceComplete.SetActive(true); // Finishing race sequence(s)
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            // Adding a complete lap after the player has done one
            lapsNumber += 1;

            realTime = PlayerPrefs.GetFloat("realTime1");

            if (LapsTimerII.realTime <= realTime) // Lap's (current) Timer (what and how it will show)
            {
                if (LapsTimerII.secondsCounter_ <= 9) // Timer's seconds
                {
                    displaySeconds_.GetComponent<TMP_Text>().text = "0" + LapsTimerII.secondsCounter_ + ".";
                }
                else
                {
                    displaySeconds_.GetComponent<TMP_Text>().text = "" + LapsTimerII.secondsCounter_ + ".";
                }

                if (LapsTimerII.minutesCounter_ <= 9) // Timer's minutes
                {
                    displayMinutes_.GetComponent<TMP_Text>().text = "" + LapsTimerII.minutesCounter_ + ":";
                }
                else
                {
                    displayMinutes_.GetComponent<TMP_Text>().text = "" + LapsTimerII.minutesCounter_ + ":";
                }

                // Timer's milliseconds
                displayMilliseconds_.GetComponent<TMP_Text>().text = "" + ((int)LapsTimerII.millisecondsCounter_).ToString(); // Casting it to int only for UI purposes
            }

            // Saving the best lap time
            PlayerPrefs.SetInt("MinSave1", LapsTimerII.minutesCounter_);
            PlayerPrefs.SetInt("SecSave1", LapsTimerII.secondsCounter_);
            PlayerPrefs.SetFloat("MilliSave1", LapsTimerII.millisecondsCounter_);
            PlayerPrefs.SetFloat("realTime1", LapsTimerII.realTime);

            // From when the timer will start
            LapsTimerII.minutesCounter_ = 0;
            LapsTimerII.secondsCounter_ = 0;
            LapsTimerII.millisecondsCounter_ = 0;
            LapsTimerII.realTime = 0;

            // Laps' number that will be shown on the game's UI
            lapsNumberCounter.GetComponent<TMP_Text>().text = "" + lapsNumber;

            halfLapTrigger.SetActive(true);  // Half lap trigger box
            fullLapTrigger.SetActive(false); // Full lap trigger box
        }
    }
}