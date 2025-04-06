using UnityEngine;

public class PlayerReset : MonoBehaviour
{
    private Vector3 startingPosition;

    void Start()
    {
        startingPosition = transform.position;
    }

    public void ResetPosition()
    {
        transform.position = startingPosition;
    }
}
