using UnityEngine;

public class ExtraResetTimers : MonoBehaviour // [Extra] reset every time counter when the player enters the main menu
{
    // Start is called before the first frame update
    void Start()
    {
        // Resetting the times on the laps (except the one which are intentionally saved)
        //Total Time Counters (Time Trials Mode)
        TotalTimeCounter.totalMinutesCounter = 0;
        TotalTimeCounter.totalSecondsCounter = 0;
        TotalTimeCounter.totalMillisecondsCounter = 0;
        TotalTimeCounter2.totalMinutesCounter2 = 0;
        TotalTimeCounter2.totalSecondsCounter2 = 0;
        TotalTimeCounter2.totalMillisecondsCounter2 = 0;
        TotalTimeCounter3.totalMinutesCounter3 = 0;
        TotalTimeCounter3.totalSecondsCounter3 = 0;
        TotalTimeCounter3.totalMillisecondsCounter3 = 0;
        //Lap Time Counter (Time Trials Mode)
        LapsTimer.minutesCounter_ = 0;
        LapsTimer.secondsCounter_ = 0;
        LapsTimer.millisecondsCounter_ = 0;
        LapsTimerII.minutesCounter_ = 0;
        LapsTimerII.secondsCounter_ = 0;
        LapsTimerII.millisecondsCounter_ = 0;
        LapsTimerIII.minutesCounter_ = 0;
        LapsTimerIII.secondsCounter_ = 0;
        LapsTimerIII.millisecondsCounter_ = 0;
        //Lap Time Counter (Split_Screen Multiplayer Mode)
        LapsTimerMultiplayer.minutesCounter_ = 0;
        LapsTimerMultiplayer.secondsCounter_ = 0;
        LapsTimerMultiplayer.millisecondsCounter_ = 0;
        LapsTimerMultiplayerII.minutesCounter_ = 0;
        LapsTimerMultiplayerII.secondsCounter_ = 0;
        LapsTimerMultiplayerII.millisecondsCounter_ = 0;
        LapsTimerMultiplayerIII.minutesCounter_ = 0;
        LapsTimerMultiplayerIII.secondsCounter_ = 0;
        LapsTimerMultiplayerIII.millisecondsCounter_ = 0;
    }
}