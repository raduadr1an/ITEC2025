using UnityEngine;

public class CameraFollowPlayers : MonoBehaviour
{
    public Transform player1;
    public Transform player2;
    public float smoothSpeed = 0.125f;
    public Vector3 offset;

    private void Start()
    {
        Vector3 midpoint = (player1.position + player2.position) / 2;

        Vector3 desiredPosition = new Vector3(transform.position.x, midpoint.y, transform.position.z) + offset;

        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        transform.position = smoothedPosition;
    }

    void LateUpdate()
    {
        if (player1 == null || player2 == null)
            return;

        Vector3 midpoint = (player1.position + player2.position) / 2;

        Vector3 desiredPosition = new Vector3(transform.position.x, midpoint.y, transform.position.z) + offset;

        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        transform.position = smoothedPosition;
    }
}
