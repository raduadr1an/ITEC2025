using System.Collections;
using UnityEngine;

public class Hide2S : MonoBehaviour
{
    private void Start()
    {
        SetInactive(this.gameObject);
    }
    public void SetInactive(GameObject _gameObject)
    {
        StartCoroutine(WaitForTwoSeconds(_gameObject));
        
    }
    private IEnumerator WaitForTwoSeconds(GameObject _gameObject)
    {
        yield return new WaitForSeconds(5f);
        _gameObject.SetActive(false);
    }
}
