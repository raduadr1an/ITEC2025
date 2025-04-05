using UnityEngine;

public class InBlackHole : MonoBehaviour
{
    public SceneChanger changer;

    private void OnTriggerEnter2D(Collider2D other)
    {
        changer.ChangeScene("Level2");
        Debug.Log("Shimpanzini Bananini");
    }
}
