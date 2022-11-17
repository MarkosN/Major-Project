using System.Collections;
using UnityEngine;

public class HalfLapTracker : MonoBehaviour
{
    public GameObject cameraViewScenario1; // Camera View for Car 1 Scenario

    public GameObject newAutomatedCameraSystem1; // By disabling the main manager of the camera views (scenarios) for an X amount of time it will help by not changing the cameras views continuously creating problems to the players

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            StartCoroutine(CameraViewScenario1());
            StartCoroutine(CameraViewScenario2());
        }
    }

    IEnumerator CameraViewScenario1() // Enabling the scenario
    {
        yield return new WaitForSeconds(0.1f);
        cameraViewScenario1.SetActive(true);
        yield return new WaitForSeconds(0.2f);
        cameraViewScenario1.SetActive(false);
    }

    IEnumerator CameraViewScenario2()
    {
        yield return new WaitForSeconds(0.2f);
        newAutomatedCameraSystem1.SetActive(false);
        yield return new WaitForSeconds(3.0f);
        newAutomatedCameraSystem1.SetActive(true);
    }
}