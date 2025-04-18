using UnityEngine;

public class TriggerDetectorV : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip soundClip;
    public SpriteRenderer spr;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player 2")
        {        
            CheckPPL1.inRangeV = true;
            audioSource.PlayOneShot(soundClip);
            spr.color = spr.color * 0.7f;
            Debug.Log("player2 has entered the trigger zone.");
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.name == "Player 2")
        {        
            CheckPPL1.inRangeV = false;
            spr.color = (spr.color * 10f)/7f;
            Debug.Log("player2 has left the trigger zone.");
        }
    }
}