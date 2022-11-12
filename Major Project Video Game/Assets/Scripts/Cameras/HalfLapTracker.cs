using System.Collections;
using UnityEngine;

public class HalfLapTracker : MonoBehaviour
{
    public GameObject cameraViewScenario1; // Camera View for Car 2 Scenario

    public GameObject newAutomatedCameraSystem1; // By disabling the main manager of the camera views (scenarios) for an X amount of time it will help by not changing the cameras views continuously creating problems to the players

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player2")
        {
            StartCoroutine(CameraViewScenario());
            StartCoroutine(CameraViewScenario2());
        }
    }

    IEnumerator CameraViewScenario() // Enabling the scenario
    {
        yield return new WaitForSeconds(0.1f);
        cameraViewScenario1.SetActive(true);
    }

    IEnumerator CameraViewScenario2() // Enabling the scenario
    {
        yield return new WaitForSeconds(0.2f);
        newAutomatedCameraSystem1.SetActive(false);
        yield return new WaitForSeconds(5.0f);
        newAutomatedCameraSystem1.SetActive(true);
    }
}