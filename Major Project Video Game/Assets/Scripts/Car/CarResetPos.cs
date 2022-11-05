using UnityEngine;

public class CarResetPos : MonoBehaviour // When the car is stuck or can't be moved it will be reset to a new position so the players can keep on going - Player 1
{
    // Player 1
    public Rigidbody car1; // Car 1
    public GameObject car1ResetPos; // Car's 1 Reset position

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            car1.transform.position = car1ResetPos.transform.position; // Fixed position to reset, reset position will be the same
            car1.velocity = new Vector3(0, 0, 0); // The car will be resetted like it was on the race start
            car1.transform.rotation = Quaternion.Euler(0, 180, 0); // Fixed roation on the car so it can start normally not in the old position that it was on the track
        }
    }
}