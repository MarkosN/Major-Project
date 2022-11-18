using UnityEngine;
using TMPro;

public class LapsManagerMultiplayer : MonoBehaviour // Managing when a lap is complete, when the race is over and the lap's timer. (TRACK 3) - Multiplayer Player 2
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
    public int lapsNumberMultiplayer;
    public int lapsToComplete;

    public float realTime; // Game's current real time

    public GameObject raceCompleteMultiplayer;

    void Update()
    {
        if (lapsNumberMultiplayer == lapsToComplete)
        {
            raceCompleteMultiplayer.SetActive(true); // Finishing race sequence(s)
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player2")
        {
            // Adding a complete lap after the player has done one
            lapsNumberMultiplayer += 1;

            realTime = PlayerPrefs.GetFloat("realTime");

            if (LapsTimerMultiplayer.realTime <= realTime) // Lap's (current) Timer (what and how it will show)
            {
                if (LapsTimerMultiplayer.secondsCounter_ <= 9) // Timer's seconds
                {
                    displaySeconds_.GetComponent<TMP_Text>().text = "0" + LapsTimerMultiplayer.secondsCounter_ + ".";
                }
                else
                {
                    displaySeconds_.GetComponent<TMP_Text>().text = "" + LapsTimerMultiplayer.secondsCounter_ + ".";
                }

                if (LapsTimerMultiplayer.minutesCounter_ <= 9) // Timer's minutes
                {
                    displayMinutes_.GetComponent<TMP_Text>().text = "" + LapsTimerMultiplayer.minutesCounter_ + ":";
                }
                else
                {
                    displayMinutes_.GetComponent<TMP_Text>().text = "" + LapsTimerMultiplayer.minutesCounter_ + ":";
                }

                // Timer's milliseconds
                displayMilliseconds_.GetComponent<TMP_Text>().text = "" + ((int)LapsTimerMultiplayer.millisecondsCounter_).ToString(); // Casting it to int only for UI purposes
            }

            // Saving the best lap time
            PlayerPrefs.SetInt("MinSaveMultiplayer", LapsTimerMultiplayer.minutesCounter_);
            PlayerPrefs.SetInt("SecSaveMultiplayer", LapsTimerMultiplayer.secondsCounter_);
            PlayerPrefs.SetFloat("MilliSaveMultiplayer", LapsTimerMultiplayer.millisecondsCounter_);
            PlayerPrefs.SetFloat("realTimeMultiplayer", LapsTimerMultiplayer.realTime);

            // From when the timer will start
            LapsTimerMultiplayer.minutesCounter_ = 0;
            LapsTimerMultiplayer.secondsCounter_ = 0;
            LapsTimerMultiplayer.millisecondsCounter_ = 0;
            LapsTimerMultiplayer.realTime = 0;

            // Laps' number that will be shown on the game's UI
            lapsNumberCounter.GetComponent<TMP_Text>().text = "" + lapsNumberMultiplayer;

            halfLapTrigger.SetActive(true);  // Half lap trigger box
            fullLapTrigger.SetActive(false); // Full lap trigger box
        }
    }
}