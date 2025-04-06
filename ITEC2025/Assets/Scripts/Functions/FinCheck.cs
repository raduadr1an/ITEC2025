using UnityEngine;

public class FinCheck : MonoBehaviour
{
    public static bool isOverV = false;
    public static bool isOverG = false;
    private bool once = false;
    private SceneChanger sceneChanger;
    private void Start()
    {
        sceneChanger = FindFirstObjectByType<SceneChanger>();
    }
    void Update()
    {
        if(isOverG && isOverV && !once)
        {
            sceneChanger.ChangeScene("Outro");
            once = true;
        }
    }
}
