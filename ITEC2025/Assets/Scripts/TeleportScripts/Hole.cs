using System.Collections;
using UnityEngine;

public class Hole : MonoBehaviour
{
    public Transform destination;
    public float delayBeforeTeleport = 0.3f;
    public float delayAfterTeleport = 0.3f;

    private bool canTeleport = true;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!canTeleport || destination == null) return;
        if (other.gameObject.name == "Player 1")
        {
            StartCoroutine(DisappearAndReappear(other.gameObject));
        }
    }

    private IEnumerator DisappearAndReappear(GameObject player)
    {
        canTeleport = false;

        var sr = player.GetComponent<SpriteRenderer>();
        var movement = player.GetComponent<PlayerMovement>();
        if (movement) movement.enabled = false;

        // Fade out
        yield return StartCoroutine(FadeSprite(sr, 1f, 0f, 0.3f));

        // Move player
        player.transform.position = destination.position;

        // Prevent immediate re-teleport
        Hole destHole = destination.GetComponent<Hole>();
        if (destHole != null)
            destHole.canTeleport = false;

        yield return new WaitForSeconds(0.2f);

        // Fade in
        yield return StartCoroutine(FadeSprite(sr, 0f, 1f, 0.3f));

        if (movement) movement.enabled = true;

        yield return new WaitForSeconds(0.5f);
        canTeleport = true;
        if (destHole != null)
            destHole.canTeleport = true;
    }
    private IEnumerator FadeSprite(SpriteRenderer sr, float startAlpha, float endAlpha, float duration)
    {
        float elapsed = 0f;
        Color color = sr.color;

        while (elapsed < duration)
        {
            float t = elapsed / duration;
            color.a = Mathf.Lerp(startAlpha, endAlpha, t);
            sr.color = color;
            elapsed += Time.deltaTime;
            yield return null;
        }

        color.a = endAlpha;
        sr.color = color;
    }
}
