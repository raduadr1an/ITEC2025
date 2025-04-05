using UnityEngine;

public class ButtonFunctions: MonoBehaviour
{
    private SceneChanger sceneChanger;
    public GameObject _gameObject;

    private void Start()
    {
        sceneChanger = FindFirstObjectByType<SceneChanger>();
    }
    public void PlayNowButton()
    {
        Hide.SetInactive(_gameObject);
        sceneChanger.ChangeScene("Intro");
    }

    public void QuitButton()
    {
        Application.Quit();
    }
}
