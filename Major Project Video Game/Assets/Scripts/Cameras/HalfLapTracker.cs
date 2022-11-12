using System.Collections;
using UnityEngine;

public class HalfLapTracker : MonoBehaviour
{
    public GameObject cameraViewScenario1; // Camera View for Car 1 Scenario

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            StartCoroutine(CameraViewScenario());
        }
    }

    IEnumerator CameraViewScenario() // Enabling the scenario and then diasbling so it won't overlap with the other
    {
        yield return new WaitForSeconds(0.1f);
        cameraViewScenario1.SetActive(true);
        yield return new WaitForSeconds(0.2f);
        cameraViewScenario1.SetActive(false);
    }
}