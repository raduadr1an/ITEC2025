using UnityEngine;

public class TriggerDetectorV2 : MonoBehaviour
{
    private bool isPressed = false;
    private PressurePlateManager manager;
    private Collider2D currentCollider;

    private void Start()
    {
        manager = FindObjectOfType<PressurePlateManager>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player 2" && !isPressed)
        {
            isPressed = true;
            currentCollider = other;
            Debug.Log($"{other.name} pressed plate: {gameObject.name}");
            manager.PlatePressed();
            // Optional: change color or animation here
        }
    }

    public void ResetPlate()
    {
        Debug.Log($"Plate {gameObject.name} has been reset.");
        isPressed = false;

        // If the player is still standing on the plate when it resets,
        // we can simulate re-entering:
        if (currentCollider != null && GetComponent<Collider2D>().IsTouching(currentCollider))
        {
            OnTriggerEnter2D(currentCollider);
        }

        // Optional: reset animation or visual here
    }
}