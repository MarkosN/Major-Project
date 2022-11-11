using UnityEngine;

public class EnableDisableCameraViews : MonoBehaviour // The manager that will be responsible for the transtions between camera views (what camera view to enable or disable and in what context)
{
    // What camera views mode will be selected
    public bool cameraViewALL;
    public bool cameraViewFIXED;

    // Fixed camera view that have been already decided
    public GameObject[] cameraViewEnable;
    public GameObject[] cameraViewDisable;

    // All the camera views to pick - The selection of the camera view will be random
    public GameObject farChaseCamera;
    public GameObject nearChaseCamera;
    public GameObject cockpitCamera;
    public GameObject bumperCamera;
    public GameObject bonnetCamera;
    private float randomCameraViewALL;

    // Start is called before the first frame update
    void Start()
    {
        randomCameraViewALL = Random.Range(1, 4);
    }

    // Update is called once per frame
    void Update() // Depending on what option I want to enable for the camera view scenario the appropriate camera view(s) will be selected
    {
        if (cameraViewALL == true)
        {
            AllCameraViewsRandom();
        }
        if (cameraViewFIXED == true)
        {
            FixedCameraViews();
        }
    }

    void FixedCameraViews() // Choosing based on the scenario what camera view I want to enable and then the rest will be disabled
    {
        for (int i = 0; i < cameraViewEnable.Length; i++)
        {
            cameraViewEnable[i].SetActive(true);
        }
        for (int i = 0; i < cameraViewDisable.Length; i++)
        {
            cameraViewDisable[i].SetActive(false);
        }
    }

    void AllCameraViewsRandom() // Choosing randomly what camera view will be enabled for the scenario - Only once the random camera view will be choosen and it will be the same for that scenario throughout the whole race
    {
        if(randomCameraViewALL == 1)
        {
            farChaseCamera.SetActive(true);
            nearChaseCamera.SetActive(false);
            cockpitCamera.SetActive(false);
            bumperCamera.SetActive(false);
            bonnetCamera.SetActive(false);
        }
        if (randomCameraViewALL == 2)
        {
            farChaseCamera.SetActive(false);
            nearChaseCamera.SetActive(true);
            cockpitCamera.SetActive(false);
            bumperCamera.SetActive(false);
            bonnetCamera.SetActive(false);
        }
        if (randomCameraViewALL == 3)
        {
            farChaseCamera.SetActive(false);
            nearChaseCamera.SetActive(false);
            cockpitCamera.SetActive(false);
            bumperCamera.SetActive(true);
            bonnetCamera.SetActive(false);
        }
        if (randomCameraViewALL == 4)
        {
            farChaseCamera.SetActive(false);
            nearChaseCamera.SetActive(false);
            cockpitCamera.SetActive(false);
            bumperCamera.SetActive(false);
            bonnetCamera.SetActive(true);
        }
    }
}