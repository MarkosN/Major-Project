using System.Collections;
using UnityEngine;

public class HalfLapTrackerV2 : MonoBehaviour
{
    public GameObject cameraViewScenario2; // Camera View for Car 2 Scenario

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player2")
        {
            StartCoroutine(CameraViewScenario());
        }
    }

    IEnumerator CameraViewScenario() // Enabling the scenario and then diasbling so it won't overlap with the other
    {
        yield return new WaitForSeconds(0.1f);
        cameraViewScenario2.SetActive(true);
        yield return new WaitForSeconds(0.2f);
        cameraViewScenario2.SetActive(false);
    }
}