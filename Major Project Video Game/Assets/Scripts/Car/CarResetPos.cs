using System.Collections;
using UnityEngine;

public class CarResetPos : MonoBehaviour // When the car is stuck or can't be moved it will be reset to a new position so the players can keep on going - Player 1
{
    // Player 1
    public Rigidbody car1; // Car 1
    public GameObject car1ResetPos; // Car's 1 Reset position
    public bool canReset; // Check if we can reset the car or we should wait X seconds

    public GameObject cameraViewScenario1; // Camera View for Car 1 Scenario

    public GameObject newAutomatedCameraSystem1; // By disabling the main manager of the camera views (scenarios) for an X amount of time it will help by not changing the cameras views continuously creating problems to the players

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1) && canReset == true)
        {
            car1.transform.position = car1ResetPos.transform.position; // Fixed position to reset, reset position will be the same
            car1.velocity = new Vector3(0, 0, 0); // The car will be resetted like it was on the race start
            car1.transform.rotation = Quaternion.Euler(0, 180, 0); // Fixed roation on the car so it can start normally not in the old position that it was on the track

            StartCoroutine(ResetTheCar());
            StartCoroutine(CameraViewScenario());
            StartCoroutine(CameraViewScenario2());
        }
    }

    IEnumerator ResetTheCar()
    {
        yield return new WaitForSeconds(0.1f);
        canReset = false;
        yield return new WaitForSeconds(1.0f);
        canReset = true;
    }

    IEnumerator CameraViewScenario() // Enabling the scenario
    {
        yield return new WaitForSeconds(0.1f);
        cameraViewScenario1.SetActive(true);
    }

    IEnumerator CameraViewScenario2()
    {
        yield return new WaitForSeconds(0.2f);
        newAutomatedCameraSystem1.SetActive(false);
        yield return new WaitForSeconds(5.0f);
        newAutomatedCameraSystem1.SetActive(true);
    }
}