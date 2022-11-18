using UnityEngine;

public class AutomatedCameraSystem2 : MonoBehaviour // This is the algorithm that will be responsible for which and when a camera view will be selected. [EARLY STAGE - Scrapped]
{
    public GameObject farChaseCam;
    public GameObject nearChaseCam;
    public GameObject cockpitCam;
    public GameObject bonnetCam;
    public GameObject bumperCam;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha2)) // Enable Far Chase Camera and Disable the rest
        {
            farChaseCam.SetActive(true);
            nearChaseCam.SetActive(false);
            cockpitCam.SetActive(false);
            bonnetCam.SetActive(false);
            bumperCam.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3)) // Enable Near Chase Camera and Disable the rest
        {
            farChaseCam.SetActive(false);
            nearChaseCam.SetActive(true);
            cockpitCam.SetActive(false);
            bonnetCam.SetActive(false);
            bumperCam.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Alpha4)) // Enable Cockpit Camera and Disable the rest
        {
            farChaseCam.SetActive(false);
            nearChaseCam.SetActive(false);
            cockpitCam.SetActive(true);
            bonnetCam.SetActive(false);
            bumperCam.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Alpha5)) // Enable Bonnet Camera and Disable the rest
        {
            farChaseCam.SetActive(false);
            nearChaseCam.SetActive(false);
            cockpitCam.SetActive(false);
            bonnetCam.SetActive(true);
            bumperCam.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Alpha6)) // Enable Bumper Camera and Disable the rest
        {
            farChaseCam.SetActive(false);
            nearChaseCam.SetActive(false);
            cockpitCam.SetActive(false);
            bonnetCam.SetActive(false);
            bumperCam.SetActive(true);
        }
    }
}