using UnityEngine;

public class TriggerDetectorVLight : MonoBehaviour
{
    public GameObject _g1, _g2;
    public AudioSource audioSource;
    public AudioClip soundClip;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player 2")
        {
            audioSource.PlayOneShot(soundClip);
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
                _g1.SetActive(false);
                _g2.SetActive(false);
            }
            
        }
    }
}