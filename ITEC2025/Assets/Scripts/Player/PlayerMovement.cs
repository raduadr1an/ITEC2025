using UnityEngine;
using UnityEngine.Audio;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rb;
    private Vector2 movement;
    public Animator anim;
    public AudioSource audioSource;
    public AudioClip soundClip;
    [Header("Custom Keybinds")]
    public KeyCode upKey = KeyCode.W;
    public KeyCode downKey = KeyCode.S;
    public KeyCode leftKey = KeyCode.A;
    public KeyCode rightKey = KeyCode.D;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        movement = Vector2.zero;

        if (Input.GetKey(upKey))
            movement.y += 1;
        if (Input.GetKey(downKey))
            movement.y -= 1;
        if (Input.GetKey(leftKey))
            movement.x -= 1;
        if (Input.GetKey(rightKey))
            movement.x += 1;

        anim.SetBool("isMoving", IsMoving());

        if (IsMoving())
        {
            anim.SetFloat("Horizontal", movement.x);
            anim.SetFloat("Vertical", movement.y);
        }

        movement.Normalize();
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }

    bool IsMoving()
    {
        return movement.x != 0 || movement.y != 0;
    }

    public void PlayAudio()
    {
        if (audioSource != null && soundClip != null)
        {
            audioSource.PlayOneShot(soundClip);
        }
    }
}
