using UnityEngine;
using TMPro;

public class PositionCounterFront : MonoBehaviour
{
    public GameObject displayPos;

    void OnTriggerExit(Collider other)
    {
       if(other.tag == "PositionTracker")
       {
            displayPos.GetComponent<TMP_Text>().text = "1st";
        } 
    }
}