using System.Collections;
using UnityEngine;

public class PositionCounterII : MonoBehaviour // Cars' Positions Counter Mechanism/Checkpoint (This is what will be used) - Track 2
{
    // In order to access in which lap each car is
    public LapsManagerMultiplayerIII lapsCount;
    public LapsManagerIII lapsCount2;

    // Cars' UI positions placeholders
    public GameObject car1PositionUI;
    public GameObject car2PositionUI;

    // Cars' UI positions numbers
    // Cars' First Place
    public GameObject car1DisplayPosFirst;
    public GameObject car2DisplayPosFirst;
    // Cars' Second Place
    public GameObject car1DisplayPosSecond;
    public GameObject car2DisplayPosSecond;

    // Cars' UI on the same lap texts
    public GameObject car1SameLapTexts;
    public GameObject car2SameLapTexts;

    private void OnTriggerEnter(Collider other) // Attached to the Position Tracker Object (in front of the start/finish line)
    {
        if (other.tag == "Player")
        {
            StartCoroutine(Car1PlacementUI());
        }
        else if (other.tag == "Player2")
        {
            StartCoroutine(Car2PlacementUI());
        }
    }

    IEnumerator Car1PlacementUI() // For Player 1 Car
    {
        yield return new WaitForSeconds(0.1f);
        if (lapsCount2.lapsNumber > lapsCount.lapsNumberMultiplayerIII) // If player 1 has completed more laps than player 2
        {
            car1PositionUI.SetActive(true);
            car2PositionUI.SetActive(true);

            car1DisplayPosFirst.SetActive(true);
            car1DisplayPosSecond.SetActive(false);

            car2DisplayPosFirst.SetActive(false);
            car2DisplayPosSecond.SetActive(true);
        }
        if (lapsCount2.lapsNumber < lapsCount.lapsNumberMultiplayerIII) // If player 2 has completed more laps than player 1
        {
            car1PositionUI.SetActive(true);
            car2PositionUI.SetActive(true);

            car1DisplayPosSecond.SetActive(true);
            car1DisplayPosFirst.SetActive(false);

            car2DisplayPosFirst.SetActive(true);
            car2DisplayPosSecond.SetActive(false);
        }
        if (lapsCount2.lapsNumber == lapsCount.lapsNumberMultiplayerIII) // If player 1 has completed the same laps like player 2
        {
            car1SameLapTexts.SetActive(true);
            car2SameLapTexts.SetActive(true);
        }

        yield return new WaitForSeconds(2.0f); // Reset everything until the players pass again the Position Tracker Object (in front of the start/finish line)
        car1PositionUI.SetActive(false);
        car2PositionUI.SetActive(false);

        car1DisplayPosFirst.SetActive(false);
        car1DisplayPosSecond.SetActive(false);

        car2DisplayPosFirst.SetActive(false);
        car2DisplayPosSecond.SetActive(false);

        car1SameLapTexts.SetActive(false);
        car2SameLapTexts.SetActive(false);
    }
    IEnumerator Car2PlacementUI() // For Player 2 Car
    {
        yield return new WaitForSeconds(0.1f);
        if (lapsCount.lapsNumberMultiplayerIII > lapsCount2.lapsNumber) // If player 2 has completed more laps than player 1
        {
            car1PositionUI.SetActive(true);
            car2PositionUI.SetActive(true);

            car2DisplayPosFirst.SetActive(true);
            car2DisplayPosSecond.SetActive(false);

            car1DisplayPosSecond.SetActive(true);
            car1DisplayPosFirst.SetActive(false);
        }
        if (lapsCount.lapsNumberMultiplayerIII < lapsCount2.lapsNumber) // If player 1 has completed more laps than player 2
        {
            car1PositionUI.SetActive(true);
            car2PositionUI.SetActive(true);

            car2DisplayPosSecond.SetActive(true);
            car2DisplayPosFirst.SetActive(false);

            car1DisplayPosSecond.SetActive(false);
            car1DisplayPosFirst.SetActive(true);
        }
        if (lapsCount.lapsNumberMultiplayerIII == lapsCount2.lapsNumber) // If player 1 has completed the same laps like player 2
        {
            car1SameLapTexts.SetActive(true);
            car2SameLapTexts.SetActive(true);
        }

        yield return new WaitForSeconds(2.0f); // Reset everything until the players pass again the Position Tracker Object (in front of the start/finish line)
        car1PositionUI.SetActive(false);
        car2PositionUI.SetActive(false);

        car1DisplayPosFirst.SetActive(false);
        car1DisplayPosSecond.SetActive(false);

        car2DisplayPosFirst.SetActive(false);
        car2DisplayPosSecond.SetActive(false);

        car1SameLapTexts.SetActive(false);
        car2SameLapTexts.SetActive(false);
    }
}