using UnityEngine;

public class FinG : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player 1")
        {
            FinCheck.isOverG = true;
        }
    }
}
