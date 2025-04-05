using UnityEngine;

public class ButtonFunctions: MonoBehaviour
{

    public void PlayNowButton()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("GameLevel");
    }

    public void QuitButton()
    {
        Application.Quit();
    }
}
