using System.Collections;
using UnityEngine;

public class RaceStartMultiplayer : MonoBehaviour // Dedicated to the split screen multiplayer game mode
{
    // Player 1
    public GameObject backgroundImage1Car1; // Laps Counter and Timers Canvas
    public GameObject backgroundImage2Car1; // Player's Position Canvas
    public GameObject trackersCar1; // Laps' Trackers

    // Player 2
    public GameObject backgroundImage1Car2; // Laps Counter and Timers Canvas
    public GameObject backgroundImage2Car2; // Player's Position Canvas
    public GameObject trackersCar2; // Laps' Trackers

    public Rigidbody car1; // Player's 1 car
    public Rigidbody car2; // Player's 2 car

    public GameObject raceIntro; // Race start sequence
    public GameObject raceIntro2; // Race start sequence

    public GameObject resetPositionMechanism; // Reseting the car 1 position in case of a racing accident
    public GameObject resetPositionMechanism2; // Reseting the car 2 position in case of a racing accident

    void Awake() // Specific things will be disabled on the start so the Start Sequence can take place without any problems
    {
        backgroundImage1Car1.SetActive(false);
        backgroundImage2Car1.SetActive(false);
        trackersCar1.SetActive(false);

        backgroundImage1Car2.SetActive(false);
        backgroundImage2Car2.SetActive(false);
        trackersCar2.SetActive(false);

        car1.constraints = RigidbodyConstraints.FreezePosition;
        car2.constraints = RigidbodyConstraints.FreezePosition;

        raceIntro.SetActive(true);
        raceIntro2.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(EnableEverything());
        StartCoroutine(ForIntroOnly());
    }

    IEnumerator EnableEverything() // After the countdown and the start sequence have ended everything will be enabled so the players can race
    {
        yield return new WaitForSeconds(11.0f);
        backgroundImage1Car1.SetActive(true);
        backgroundImage2Car1.SetActive(true);
        trackersCar1.SetActive(true);
        backgroundImage1Car2.SetActive(true);
        backgroundImage2Car2.SetActive(true);
        trackersCar2.SetActive(true);

        car1.constraints = RigidbodyConstraints.None;
        car2.constraints = RigidbodyConstraints.None;

        resetPositionMechanism.SetActive(true);
        resetPositionMechanism2.SetActive(true);
    }

    IEnumerator ForIntroOnly() // The intro will take place a little longer so it can be completed smoothly without interrupting the gameplay
    {
        yield return new WaitForSeconds(11.31f);
        raceIntro.SetActive(false);
    }
}