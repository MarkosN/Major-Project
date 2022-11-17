using System.Collections;
using UnityEngine;

public class AutomatedCameraSystem : MonoBehaviour // This is only for the manually camera view changes for the PRACTICE MODE - Not for the New Automated Camera System
{
    public GameObject farChaseCam;
    public GameObject nearChaseCam;
    public GameObject bonnetCam;
    public GameObject bumperCam;

    private int cameraViewSelection;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)) // Changing the Camera View
        {
            if (cameraViewSelection == 3) // 4 Camera Views in Total
            {
                cameraViewSelection = 0;
            }
            else
            {
                cameraViewSelection += 1;
            }

            StartCoroutine(CamerasViews()); // Changing will be with Coroutine (Simple and Easy Way) 
        }
    }
    
    IEnumerator CamerasViews()
    {
        yield return new WaitForSeconds(0.01f); // Very Little Time between Cameras Views Changes

        if (cameraViewSelection == 0) // Enable Near Chase Camera and Disable the rest
        {
            farChaseCam.SetActive(false);
            nearChaseCam.SetActive(true);
            bonnetCam.SetActive(false);
            bumperCam.SetActive(false);
        }
        if (cameraViewSelection == 1) // Enable Far Chase Camera and Disable the rest
        {
            farChaseCam.SetActive(true);
            nearChaseCam.SetActive(false);
            bonnetCam.SetActive(false);
            bumperCam.SetActive(false);
        }
        if (cameraViewSelection == 2) // Enable Bumper Camera and Disable the rest
        {
            farChaseCam.SetActive(false);
            nearChaseCam.SetActive(false);
            bonnetCam.SetActive(false);
            bumperCam.SetActive(true);
        }
        if (cameraViewSelection == 3) // Enable Bonnet Camera and Disable the rest
        {
            farChaseCam.SetActive(false);
            nearChaseCam.SetActive(false);
            bonnetCam.SetActive(true);
            bumperCam.SetActive(false);
        }
    }
}