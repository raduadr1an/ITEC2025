using UnityEngine;

public class TriggerDetectorV : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player 2")
        {        
            CheckPPL1.inRangeV = true;
            Debug.Log("player2 has entered the trigger zone.");
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.name == "Player 2")
        {        
            CheckPPL1.inRangeV = false;
            Debug.Log("player2 has left the trigger zone.");
        }
    }
}