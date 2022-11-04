using System.Collections;
using UnityEngine;

public class MouseCursorManagerV2 : MonoBehaviour // A special version for the Main Menu only
{
    public float introTimeDisable2; // When the dark intro effect is completely disabled

    void Awake()
    {
        StartCoroutine(GiveMouseAccess());
    }

    IEnumerator GiveMouseAccess() // When the player will be able to have the complete control of its mouse
    {
        yield return new WaitForSeconds(introTimeDisable2); // Depending the duration of the dark intro's animation

        // User Can See and Control the Mouse Cursor
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}