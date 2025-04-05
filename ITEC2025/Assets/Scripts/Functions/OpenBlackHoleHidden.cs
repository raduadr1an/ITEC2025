using System.Collections;
using UnityEngine;

public class OpenBlackHoleHidden : MonoBehaviour
{
    public GameObject _gameObject;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.name == "Player 2")
        {
            _gameObject.SetActive(true);
            StartCoroutine(WaitForTwoSeconds());
        }
    }

    private IEnumerator WaitForTwoSeconds()
    {
        yield return new WaitForSeconds(2f);
        _gameObject.SetActive(false);
    }
}
