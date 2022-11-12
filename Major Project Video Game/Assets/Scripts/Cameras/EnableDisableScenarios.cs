using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableDisableScenarios : MonoBehaviour // Managing which camera view scenario to enable and disabling the rest
{
    public GameObject[] enableScenarios; // Enable again the current camera view scenario that the script is attached
    public GameObject[] disableScenarios; // Disable the rest camera view scenarios

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < enableScenarios.Length; i++)
        {
            enableScenarios[i].SetActive(true);
        }
        for (int i = 0; i < disableScenarios.Length; i++)
        {
            disableScenarios[i].SetActive(false);
        }
    }
}