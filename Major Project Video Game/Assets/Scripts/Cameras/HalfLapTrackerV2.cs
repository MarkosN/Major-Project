using System.Collections;
using UnityEngine;

public class HalfLapTrackerV2 : MonoBehaviour
{
    public GameObject cameraViewScenario2; // Camera View for Car 2 Scenario

    public GameObject newAutomatedCameraSystem2; // By disabling the main manager of the camera views (scenarios) for an X amount of time it will help by not changing the cameras views continuously creating problems to the players

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player2")
        {
            StartCoroutine(CameraViewScenario1());
            StartCoroutine(CameraViewScenario2());
        }
    }

    IEnumerator CameraViewScenario1() // Enabling the scenario
    {
        yield return new WaitForSeconds(0.1f);
        cameraViewScenario2.SetActive(true);
        yield return new WaitForSeconds(0.2f);
        cameraViewScenario2.SetActive(false);
    }

    IEnumerator CameraViewScenario2()
    {
        yield return new WaitForSeconds(0.2f);
        newAutomatedCameraSystem2.SetActive(false);
        yield return new WaitForSeconds(3.0f);
        newAutomatedCameraSystem2.SetActive(true);
    }
}