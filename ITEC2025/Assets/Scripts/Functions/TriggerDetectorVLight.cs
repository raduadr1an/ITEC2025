using UnityEngine;

public class TriggerDetectorVLight : MonoBehaviour
{
    public GameObject _g1, _g2;
    public AudioSource audioSource;
    public AudioClip soundClip;
    public SpriteRenderer spr;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player 2")
        {
            audioSource.PlayOneShot(soundClip);
            spr.color = spr.color * 0.7f;
            _g1.SetActive(true);
            _g2.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.name == "Player 2")
        {
            if(_g1 && _g2)
            {
                spr.color = (spr.color * 10f) / 7f;
                _g1.SetActive(false);
                _g2.SetActive(false);
            }
            
        }
    }
}