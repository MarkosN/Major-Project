using System.Collections;
using UnityEngine;

public class CarResetPosV2 : MonoBehaviour // When the car is stuck or can't be moved it will be reset to a new position so the players can keep on going - Player 2
{
    // Player 2
    public Rigidbody car2; // Car 2
    public GameObject car2ResetPos; // Car's 2 Reset position
    public bool canReset; // Check if we can reset the car or we should wait X seconds

    public GameObject cameraViewScenario2; // Camera View for Car 2 Scenario

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha9) && canReset == true)
        {
            car2.transform.position = car2ResetPos.transform.position; // Fixed position to reset, reset position will be the same
            car2.velocity = new Vector3(0, 0, 0); // The car will be resetted like it was on the race start
            car2.transform.rotation = Quaternion.Euler(0, 180, 0); // Fixed roation on the car so it can start normally not in the old position that it was on the track

            StartCoroutine(ResetTheCar());
            StartCoroutine(CameraViewScenario());
        }
    }

    IEnumerator ResetTheCar()
    {
        yield return new WaitForSeconds(0.1f);
        canReset = false;
        yield return new WaitForSeconds(1.0f);
        canReset = true;
    }

    IEnumerator CameraViewScenario() // Enabling the scenario and then diasbling so it won't overlap with the other
    {
        yield return new WaitForSeconds(0.1f);
        cameraViewScenario2.SetActive(true);
        yield return new WaitForSeconds(1.0f);
        cameraViewScenario2.SetActive(false);
    }
}