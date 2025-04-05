using UnityEngine;

public class TriggerDetectorG : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        CheckPPL1.inRangeG = true;
        if (other.gameObject.name == "Player 1")
        {
            Debug.Log("player1 has entered the trigger zone.");
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        CheckPPL1.inRangeG = false;
        if (other.gameObject.name == "Player 1")
        {
            Debug.Log("player1 has left the trigger zone.");
        }
    }
}