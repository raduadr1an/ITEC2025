using UnityEngine;

public class TriggerDetectorG : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.gameObject.name == "Player 1")
        {
            CheckPPL1.inRangeG = true;
            Debug.Log("player1 has entered the trigger zone.");
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
       
        if (other.gameObject.name == "Player 1")
        { 
            CheckPPL1.inRangeG = false;
            Debug.Log("player1 has left the trigger zone.");
        }
    }
}