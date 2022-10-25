using UnityEngine;
using TMPro;

public class PositionCounterBack : MonoBehaviour
{
    public GameObject displayPos;

    void OnTriggerExit(Collider other)
    {
       if (other.tag == "PositionTracker")
       {
           displayPos.GetComponent<TMP_Text>().text = "2nd";
       }
    }
}