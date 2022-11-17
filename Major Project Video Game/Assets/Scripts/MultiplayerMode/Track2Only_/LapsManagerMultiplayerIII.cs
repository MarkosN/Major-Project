using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LapsManagerMultiplayerIII : MonoBehaviour // Managing when a lap is complete, when the race is over and the lap's timer. (TRACK 2) - Multiplayer Player 2
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
    public int lapsNumberMultiplayerIII;
    public int lapsToComplete;

    public float realTime; // Game's current real time

    public GameObject raceCompleteMultiplayerIII;

    void Update()
    {
        if (lapsNumberMultiplayerIII == lapsToComplete)
        {
            raceCompleteMultiplayerIII.SetActive(true); // Finishing race sequence(s)
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player2")
        {
            // Adding a complete lap after the player has done one
            lapsNumberMultiplayerIII += 1;

            realTime = PlayerPrefs.GetFloat("realTime");

            if (LapsTimerMultiplayerIII.realTime <= realTime) // Lap's (current) Timer (what and how it will show)
            {
                if (LapsTimerMultiplayerIII.secondsCounter_ <= 9) // Timer's seconds
                {
                    displaySeconds_.GetComponent<TMP_Text>().text = "0" + LapsTimerMultiplayerIII.secondsCounter_ + ".";
                }
                else
                {
                    displaySeconds_.GetComponent<TMP_Text>().text = "" + LapsTimerMultiplayerIII.secondsCounter_ + ".";
                }

                if (LapsTimerMultiplayerIII.minutesCounter_ <= 9) // Timer's minutes
                {
                    displayMinutes_.GetComponent<TMP_Text>().text = "" + LapsTimerMultiplayerIII.minutesCounter_ + ":";
                }
                else
                {
                    displayMinutes_.GetComponent<TMP_Text>().text = "" + LapsTimerMultiplayerIII.minutesCounter_ + ":";
                }

                // Timer's milliseconds
                displayMilliseconds_.GetComponent<TMP_Text>().text = "" + ((int)LapsTimerMultiplayerIII.millisecondsCounter_).ToString(); // Casting it to int only for UI purposes
            }

            // Saving the best lap time
            PlayerPrefs.SetInt("MinSaveMultiplayer3", LapsTimerMultiplayerIII.minutesCounter_);
            PlayerPrefs.SetInt("SecSaveMultiplayer3", LapsTimerMultiplayerIII.secondsCounter_);
            PlayerPrefs.SetFloat("MilliSaveMultiplayer3", LapsTimerMultiplayerIII.millisecondsCounter_);
            PlayerPrefs.SetFloat("realTimeMultiplayer3", LapsTimerMultiplayerIII.realTime);

            // From when the timer will start
            LapsTimerMultiplayerIII.minutesCounter_ = 0;
            LapsTimerMultiplayerIII.secondsCounter_ = 0;
            LapsTimerMultiplayerIII.millisecondsCounter_ = 0;
            LapsTimerMultiplayerIII.realTime = 0;

            // Laps' number that will be shown on the game's UI
            lapsNumberCounter.GetComponent<TMP_Text>().text = "" + lapsNumberMultiplayerIII;

            halfLapTrigger.SetActive(true);  // Half lap trigger box
            fullLapTrigger.SetActive(false); // Full lap trigger box
        }
    }
}