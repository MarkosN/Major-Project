using System.Collections;
using UnityEngine;

public class PracticeCamerasManager : MonoBehaviour // Only for the practice mode (part of the intro)
{
    public GameObject cockpitCamera; // Disabling permanently the cockpit camera (cockpit camera only for intro)
    public GameObject otherCamera; // Enable the near view camera for the player to start
    public GameObject cameraManagerEnable; // Enable the mechanism for the player to be able to change the camera views
    public GameObject modesExtraInfo; // Enable and then disable some extra info about the practice mode

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ManagingCameras());
        StartCoroutine(ManagingInfo());
    }

    IEnumerator ManagingCameras() // Managing cameras views and manager
    {
        yield return new WaitForSeconds(11.0f);
        otherCamera.SetActive(true);
        cockpitCamera.SetActive(false);
        cameraManagerEnable.SetActive(true);
    }

    IEnumerator ManagingInfo() // Managing the extra info that it provided to the players about this mode
    {
        yield return new WaitForSeconds(11.1f);
        modesExtraInfo.SetActive(true);
        yield return new WaitForSeconds(10.0f);
        modesExtraInfo.SetActive(false);
    }
}