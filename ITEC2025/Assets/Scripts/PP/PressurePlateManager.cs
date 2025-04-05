using System.Collections;
using UnityEngine;

public class PressurePlateManager : MonoBehaviour
{
    public int totalPlates = 6;
    private int platesPressed = 0;
    private bool timerRunning = false;
    public float timeLimit = 15f;
    private Coroutine timerCoroutine;
    public static bool done = false;

    public void PlatePressed()
    {
        if (!timerRunning)
        {
            timerCoroutine = StartCoroutine(PlateTimer());
        }

        platesPressed++;

        if (platesPressed >= totalPlates)
        {
            done = true;
            if (timerCoroutine != null)
                StopCoroutine(timerCoroutine);
        }
    }

    private IEnumerator PlateTimer()
    {
        timerRunning = true;
        float timer = timeLimit;
        while (timer > 0)
        {
            timer -= Time.deltaTime;
            yield return null;
        }

        Debug.Log("Time ran out! Resetting plates.");
        ResetPlates();
    }

    public void ResetPlates()
    {
        platesPressed = 0;
        timerRunning = false;

        TriggerDetectorG2[] arrG = FindObjectsByType<TriggerDetectorG2>(FindObjectsSortMode.None);
        foreach (var plate in arrG)
        {
            plate.ResetPlate();
        }

        TriggerDetectorV2[] arrV = FindObjectsByType<TriggerDetectorV2>(FindObjectsSortMode.None);
        foreach (var plate in arrV)
        {
            plate.ResetPlate();
        }
    }
}
