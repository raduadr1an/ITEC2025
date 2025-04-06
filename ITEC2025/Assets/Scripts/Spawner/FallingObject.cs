using Unity.VisualScripting;
using UnityEngine;

public class FallingObject : MonoBehaviour
{
    public string _name;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == _name)
        {
            PlayerReset pr = other.GetComponent<PlayerReset>();
            if (pr != null)
            {
                pr.ResetPosition();
            }
        }
    }
}