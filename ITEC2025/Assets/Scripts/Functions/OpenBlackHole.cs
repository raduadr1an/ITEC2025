using System.Collections;
using UnityEngine;

public class OpenBlackHole : MonoBehaviour
{
    public GameObject _gameObject;

    private void Update()
    {
        if(CheckPPL1.isOpen)
        {
            _gameObject.SetActive(true);
            StartCoroutine(WaitForTwoSeconds());
            CheckPPL1.isOpen = false;
        }
    }

    private IEnumerator WaitForTwoSeconds()
    {
        yield return new WaitForSeconds(2f);
        _gameObject.SetActive(false);
    }
}
