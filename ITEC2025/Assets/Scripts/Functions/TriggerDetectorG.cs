using UnityEngine;

public class TriggerDetectorG : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip soundClip;
    public SpriteRenderer spr;
    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.gameObject.name == "Player 1")
        {
            CheckPPL1.inRangeG = true;
            audioSource.PlayOneShot(soundClip);
            spr.color = spr.color * 0.7f;
            Debug.Log("player1 has entered the trigger zone.");
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
       
        if (other.gameObject.name == "Player 1")
        { 
            CheckPPL1.inRangeG = false;
            spr.color = (spr.color * 10f) / 7f;
            Debug.Log("player1 has left the trigger zone.");
        }
    }
}