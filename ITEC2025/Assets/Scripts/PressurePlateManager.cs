using System.Collections;
using UnityEngine;

public class PressurePlateManager : MonoBehaviour
{
    public int totalPlates = 6;
    private int platesPressed = 0;
    private bool timerRunning = false;
    public float timeLimit = 15f;
    private Coroutine timerCoroutine;

    public void PlatePressed()
    {
        if (!timerRunning)
        {
            timerCoroutine = StartCoroutine(PlateTimer());
        }

        platesPressed++;

        if (platesPressed >= totalPlates)
        {
            Debug.Log("All pressure plates pressed in time! Puzzle complete.");
            if (timerCoroutine != null)
                StopCoroutine(timerCoroutine);
            // Do something like open a door here
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

    [System.Obsolete]
    public void ResetPlates()
    {
        platesPressed = 0;
        timerRunning = false;

        // Reset visuals or states on each plate
        TriggerDetectorG2[] arrG = FindObjectsOfType<TriggerDetectorG2>();
        for (int i = 0; i < arrG.Length; i++)
        {
            TriggerDetectorG2 plate = arrG[i];
            plate.ResetPlate();
        }
        TriggerDetectorV2[] arrV = FindObjectsOfType<TriggerDetectorV2>();
        for (int i = 0; i < arrV.Length; i++)
        {
            TriggerDetectorV2 plate = arrV[i];
            plate.ResetPlate();
        }
    }
}
