using UnityEngine;

public class OpenBlackHoleTimer : MonoBehaviour
{
    public GameObject _gameObject;

    private void Update()
    {
        if (PressurePlateManager.done)
        {
            _gameObject.SetActive(true);
        }
    }
}
