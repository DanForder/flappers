using UnityEngine;

public class BirdController : MonoBehaviour
{
    public GameManager gameManager;
    public float velocity;
    public AudioSource audioSource;
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && gameManager.active)
        {
            rb.velocity = Vector2.up * velocity;
            audioSource.Play();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameManager.GameOver();
    }
}
