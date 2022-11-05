using UnityEngine;

public class CarResetPosV2 : MonoBehaviour // When the car is stuck or can't be moved it will be reset to a new position so the players can keep on going - Player 2
{
    // Player 2
    public Rigidbody car2; // Car 2
    public GameObject car2ResetPos; // Car's 2 Reset position

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            car2.transform.position = car2ResetPos.transform.position; // Fixed position to reset, reset position will be the same
            car2.velocity = new Vector3(0, 0, 0); // The car will be resetted like it was on the race start
            car2.transform.rotation = Quaternion.Euler(0, 180, 0); // Fixed roation on the car so it can start normally not in the old position that it was on the track
        }
    }
}