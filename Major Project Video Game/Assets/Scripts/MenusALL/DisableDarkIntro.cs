using System.Collections;
using UnityEngine;

public class DisableDarkIntro : MonoBehaviour // Dark Intro will be a black image which will fade out in the beginning of the main menu
{
    public GameObject darkIntro; // Dark Intro will be in on the start of the main menu
    public float introTimeDisable; // When to disable the dark intro effect
    void Awake()
    {
        StartCoroutine(DarkIntroDisable());
    }

    IEnumerator DarkIntroDisable()
    {
        yield return new WaitForSeconds(introTimeDisable); // Depending the duration of the dark intro's animation
        darkIntro.SetActive(false); // Disable it after it is played in order to not cause problem with the main menu of the game
    }
}