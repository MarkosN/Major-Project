using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingScene : MonoBehaviour // Responsible about the time it will take to go from loading scene to the main menu scene
{
    private float randomSec; // The seconds that it will take from the loading scene to the main menu scene will be random but with limits

    private void Awake()
    {
        randomSec = Random.Range(3, 6);
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(TransferToMainMenu());
    }

    IEnumerator TransferToMainMenu() // Transfer to Main Menu
    {
        yield return new WaitForSeconds(randomSec);
        SceneManager.LoadScene("MainMenu");
    }
}