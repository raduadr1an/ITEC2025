using UnityEngine;

public class OpenBlackHoleHidden : MonoBehaviour
{
    public GameObject _gameObject;
    public AudioSource audioSource;
    public AudioClip soundClip;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.name == "Player 2")
        {
            audioSource.PlayOneShot(soundClip);
            _gameObject.SetActive(true);
        }
    }
}
