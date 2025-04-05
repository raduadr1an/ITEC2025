using UnityEngine;

public class TriggerDetectorV : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        CheckPPL1.inRangeV = true;
        if (other.gameObject.name == "Player 2")
        {
            Debug.Log("player2 has entered the trigger zone.");
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        CheckPPL1.inRangeV = false;
        if (other.gameObject.name == "Player 2")
        {
            Debug.Log("player2 has left the trigger zone.");
        }
    }
}