using System.Collections;
using UnityEngine;

public class RaceStart : MonoBehaviour // Race Start Sequence (same (almost) for all the modes)
{
    public GameObject backgroundImage1; // Laps Counter and Timers Canvas
    public GameObject backgroundImage2; // Player's Position Canvas
    public GameObject trackers; // Laps' Trackers

    public Rigidbody car; // Player's car

    public GameObject raceIntro; // Race start sequence

    public GameObject resetPositionMechanism; // Reseting the cars positions in case of a racing accident

    public GameObject cameraViewScenario1; // Camera View for Car 1 Scenario
    public GameObject newAutomatedCameraSystem1; // By disabling the main manager of the camera views (scenarios) for an X amount of time it will help by not changing the cameras views continuously creating problems to the players

    void Awake() // Specific things will be disabled on the start so the Start Sequence can take place without any problems
    {
        backgroundImage1.SetActive(false);
        backgroundImage2.SetActive(false);
        trackers.SetActive(false);

        car.constraints = RigidbodyConstraints.FreezePosition;

        raceIntro.SetActive(true);

        StartCoroutine(CameraViewScenario());
        StartCoroutine(CameraViewScenario2());
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

        resetPositionMechanism.SetActive(true);
    }

    IEnumerator ForIntroOnly() // The intro will take place a little longer so it can be completed smoothly without interrupting the gameplay
    {
        yield return new WaitForSeconds(11.31f);
        raceIntro.SetActive(false);
    }

    IEnumerator CameraViewScenario() // Enabling the scenarios
    {
        yield return new WaitForSeconds(11.0f);
        cameraViewScenario1.SetActive(true);
        yield return new WaitForSeconds(0.1f);
        cameraViewScenario1.SetActive(false);
    }
    IEnumerator CameraViewScenario2()
    {
        yield return new WaitForSeconds(11.1f);
        newAutomatedCameraSystem1.SetActive(false);
        yield return new WaitForSeconds(3.0f);
        newAutomatedCameraSystem1.SetActive(true);
    }
}