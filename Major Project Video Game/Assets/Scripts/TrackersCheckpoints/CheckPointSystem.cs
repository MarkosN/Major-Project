using UnityEngine;
using System;
using TMPro;

public class CheckPointSystem : MonoBehaviour // Scraped
{
    public float[] checkpointsDistances;

    public Transform player1;
    public Transform player2;

    private float firstPos;
    private float secondPos;

    public GameObject nextCheckpoint;

    public GameObject car1DisplayPosFront;
    public GameObject car2DisplayPosFront;

    public LapsManagerMultiplayer lapsCount;
    public LapsManager lapsCount2;

    // Start is called before the first frame update
    void Start()
    {
        nextCheckpoint.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        checkpointsDistances[0] = Vector3.Distance(transform.position, player1.position);
        checkpointsDistances[1] = Vector3.Distance(transform.position, player2.position);

        Array.Sort(checkpointsDistances);

        firstPos = checkpointsDistances[0];
        secondPos = checkpointsDistances[1];

        float car1Distance = Vector3.Distance(transform.position, player1.position);
        float car2Distance = Vector3.Distance(transform.position, player2.position);

        if (car1Distance == firstPos && lapsCount2.lapsNumber >= lapsCount.lapsNumberMultiplayer)
        {
            car1DisplayPosFront.GetComponent<TMP_Text>().text = "1st";
        }
        if (car1Distance == secondPos && lapsCount2.lapsNumber <= lapsCount.lapsNumberMultiplayer)
        {
            car1DisplayPosFront.GetComponent<TMP_Text>().text = "2nd";
        }

        if (car2Distance == firstPos && lapsCount.lapsNumberMultiplayer >= lapsCount2.lapsNumber)
        {
            car2DisplayPosFront.GetComponent<TMP_Text>().text = "1st";
        }
        if (car2Distance == secondPos && lapsCount.lapsNumberMultiplayer <= lapsCount2.lapsNumber)
        {
            car2DisplayPosFront.GetComponent<TMP_Text>().text = "2nd";
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            nextCheckpoint.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}