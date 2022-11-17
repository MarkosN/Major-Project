using UnityEngine;

public class EnableDisableCameraViews : MonoBehaviour // The manager that will be responsible for the transtions between camera views (what camera view to enable or disable)
{
    // Fixed camera view that have been already decided to enable and then disable the rest
    public GameObject[] cameraViewEnable;
    public GameObject[] cameraViewDisable;

    // Start is called before the first frame update
    void Start()
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

    // Update is called once per frame
    void Update()
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
}