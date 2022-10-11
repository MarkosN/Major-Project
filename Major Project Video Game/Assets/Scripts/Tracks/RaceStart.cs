using System.Collections;
using UnityEngine;

public class RaceStart : MonoBehaviour // Race Start Sequence (same (almost) for all the modes)
{
    public GameObject backgroundImage1; // Laps Counter and Timers Canvas
    public GameObject backgroundImage2; // Player's Position Canvas
    public GameObject trackers; // Laps' Trackers

    public Rigidbody car; // Player's car

    public GameObject raceIntro; // Race start sequence

    void Awake() // Specific things will be disabled on the start so the Start Sequence can take place without any problems
    {
        backgroundImage1.SetActive(false);
        backgroundImage2.SetActive(false);
        trackers.SetActive(false);

        car.constraints = RigidbodyConstraints.FreezePosition;

        raceIntro.SetActive(true);
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
        backgroundImage1.SetActive(true);
        backgroundImage2.SetActive(true);
        trackers.SetActive(true);

        car.constraints = RigidbodyConstraints.None;
    }

    IEnumerator ForIntroOnly() // The intro will take place a little longer so it can be completed smoothly without interrupting the gameplay
    {
        yield return new WaitForSeconds(11.31f);
        raceIntro.SetActive(false);
    }
}