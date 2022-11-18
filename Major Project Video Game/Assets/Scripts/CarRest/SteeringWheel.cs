using UnityEngine;

public class SteeringWheel : MonoBehaviour // Giving the ability for the car's wheel to steer (visually part) [Early Stage]
{
    public GameObject carSteeringWheel;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.W))
        {
            transform.Rotate(new Vector3(0, 0, -1) * (50 * Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.S))
        {
            transform.Rotate(new Vector3(0, 0, -1) * (50 * Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.W))
        {
            transform.Rotate(new Vector3(0, 0, 1) * (50 * Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.S))
        {
            transform.Rotate(new Vector3(0, 0, 1) * (50 * Time.deltaTime));
        }
    }
}