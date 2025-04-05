using UnityEngine;

public class InBlackHole : MonoBehaviour
{
    private SceneChanger changer;
    public GameObject _gameObject;
    public string _name;

    private void Start()
    {
        changer = FindFirstObjectByType<SceneChanger>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        _gameObject.SetActive(false);
        changer.ChangeScene(_name);
    }
}
