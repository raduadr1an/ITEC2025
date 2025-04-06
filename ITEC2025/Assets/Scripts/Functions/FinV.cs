using UnityEngine;

public class FinV : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.name == "Player 2")
        {
            FinCheck.isOverV = true;
        }
    }
}
