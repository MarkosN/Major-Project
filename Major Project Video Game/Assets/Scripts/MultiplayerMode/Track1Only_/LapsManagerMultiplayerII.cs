using UnityEngine;
using TMPro;

public class LapsManagerMultiplayerII : MonoBehaviour // Managing when a lap is complete, when the race is over and the lap's timer. (TRACK 1) - Multiplayer Player 2
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
    public int lapsNumberMultiplayerII;
    public int lapsToComplete;

    public float realTime; // Game's current real time

    public GameObject raceCompleteMultiplayerII;

    void Update()
    {
        if (lapsNumberMultiplayerII == lapsToComplete)
        {
            raceCompleteMultiplayerII.SetActive(true); // Finishing race sequence(s)
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player2")
        {
            // Adding a complete lap after the player has done one
            lapsNumberMultiplayerII += 1;

            realTime = PlayerPrefs.GetFloat("realTime");

            if (LapsTimerMultiplayerII.realTime <= realTime) // Lap's (current) Timer (what and how it will show)
            {
                if (LapsTimerMultiplayerII.secondsCounter_ <= 9) // Timer's seconds
                {
                    displaySeconds_.GetComponent<TMP_Text>().text = "0" + LapsTimerMultiplayerII.secondsCounter_ + ".";
                }
                else
                {
                    displaySeconds_.GetComponent<TMP_Text>().text = "" + LapsTimerMultiplayerII.secondsCounter_ + ".";
                }

                if (LapsTimerMultiplayerII.minutesCounter_ <= 9) // Timer's minutes
                {
                    displayMinutes_.GetComponent<TMP_Text>().text = "" + LapsTimerMultiplayerII.minutesCounter_ + ":";
                }
                else
                {
                    displayMinutes_.GetComponent<TMP_Text>().text = "" + LapsTimerMultiplayerII.minutesCounter_ + ":";
                }

                // Timer's milliseconds
                displayMilliseconds_.GetComponent<TMP_Text>().text = "" + ((int)LapsTimerMultiplayerII.millisecondsCounter_).ToString(); // Casting it to int only for UI purposes
            }

            // Saving the best lap time
            PlayerPrefs.SetInt("MinSaveMultiplayerII", LapsTimerMultiplayerII.minutesCounter_);
            PlayerPrefs.SetInt("SecSaveMultiplayerII", LapsTimerMultiplayerII.secondsCounter_);
            PlayerPrefs.SetFloat("MilliSaveMultiplayerII", LapsTimerMultiplayerII.millisecondsCounter_);
            PlayerPrefs.SetFloat("realTimeMultiplayerII", LapsTimerMultiplayerII.realTime);

            // From when the timer will start
            LapsTimerMultiplayerII.minutesCounter_ = 0;
            LapsTimerMultiplayerII.secondsCounter_ = 0;
            LapsTimerMultiplayerII.millisecondsCounter_ = 0;
            LapsTimerMultiplayerII.realTime = 0;

            // Laps' number that will be shown on the game's UI
            lapsNumberCounter.GetComponent<TMP_Text>().text = "" + lapsNumberMultiplayerII;

            halfLapTrigger.SetActive(true);  // Half lap trigger box
            fullLapTrigger.SetActive(false); // Full lap trigger box
        }
    }
}