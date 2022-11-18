using UnityEngine;

public class MouseCursorManager : MonoBehaviour
{
    public bool lockMouse;
    public bool unlockMouse;

    // Start is called before the first frame update
    void Start()
    {
        if (lockMouse == true && unlockMouse == false)
        {
            // User Cannot See and Control the Mouse Cursor
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
        else if (lockMouse == false && unlockMouse == true)
        {
            // User Can See and Control the Mouse Cursor
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
}