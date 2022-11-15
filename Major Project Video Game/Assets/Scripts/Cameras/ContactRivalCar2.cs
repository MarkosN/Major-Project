using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContactRivalCar2 : MonoBehaviour
{
    public GameObject cameraViewScenario; // Camera View for Car 2 Scenario

    public GameObject newAutomatedCameraSystem; // By disabling the main manager of the camera views (scenarios) for an X amount of time it will help by not changing the cameras views continuously creating problems to the players

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
        cameraViewScenario.SetActive(true);
        yield return new WaitForSeconds(0.2f);
        cameraViewScenario.SetActive(false);
    }

    IEnumerator CameraViewScenario2()
    {
        yield return new WaitForSeconds(0.2f);
        newAutomatedCameraSystem.SetActive(false);
        yield return new WaitForSeconds(3.0f);
        newAutomatedCameraSystem.SetActive(true);
    }
}
