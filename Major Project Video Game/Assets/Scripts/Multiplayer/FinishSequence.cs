using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishSequence : MonoBehaviour // Race Finish Sequence Manager - What will happen when the race is over - Car 1
{
    public GameObject car1Canvas; // Laps Counter, Timers, Position and Speedometer Canvas (car 1)
    public GameObject car2Canvas; // Laps Counter, Timers, Position and Speedometer Canvas (car 2)
    public GameObject car1WheelsParticles; // Car's 1 wheels smoke
    public GameObject car2WheelsParticles; // Car's 2 wheels smoke

    public GameObject winCanvasCar1; // Win Canvas UI
    public GameObject loseCanvasCar2; // Lose Canvas UI

    public GameObject winParticleEffectCar1; // Win particle effect for car 1
    public GameObject loseParticleEffectCar2; // Lose particle effect for car 2

    public Rigidbody car1; // Player's 1 car
    public Rigidbody car2; // Player's 2 car

    public GameObject positionTracker; // The tracker that counts the players' positions

    // Update is called once per frame
    void Update()
    {
        car1Canvas.SetActive(false);
        car2Canvas.SetActive(false);
        winCanvasCar1.SetActive(true);
        loseCanvasCar2.SetActive(true);
        winParticleEffectCar1.SetActive(true);
        loseParticleEffectCar2.SetActive(true);
        positionTracker.SetActive(false);
        StartCoroutine(DisableCarPositionandRotation());
        StartCoroutine(ReturnToMenu());
    }

    IEnumerator DisableCarPositionandRotation() // After the race is over player won't be able to control the car anymore
    {
        yield return new WaitForSeconds(0.5f);
        car1.constraints = RigidbodyConstraints.FreezePosition;
        car1.constraints = RigidbodyConstraints.FreezeRotation;
        car2.constraints = RigidbodyConstraints.FreezePosition;
        car2.constraints = RigidbodyConstraints.FreezeRotation;
        car1WheelsParticles.SetActive(false);
        car2WheelsParticles.SetActive(false);
    }

    IEnumerator ReturnToMenu()
    {
        yield return new WaitForSeconds(5.0f);
        SceneManager.LoadScene("LoadingScene");
    }
}