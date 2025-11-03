using UnityEngine;

public class BallController : MonoBehaviour
{
    [Header("Ball Settings")]
    public float speed = 8f;           // Ball movement speed
    public float minDirection = 0.5f;  // Minimum direction component

    [Header("Visual Effects")]
    public GameObject sparksVFX;       // Sparks effect prefab

    [Header("Audio Effects")]
    public AudioClip wallHitSFX;       // Sound when hitting wall
    public AudioClip racketHitSFX;     // Sound when hitting racket

    private Vector3 direction;         // Current movement direction
    private Rigidbody rb;              // Rigidbody reference
    private AudioSource audioSource;   // Audio source for sounds

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true; // Prevent unwanted spin
        audioSource = gameObject.AddComponent<AudioSource>(); // Add audio source dynamically
        audioSource.playOnAwake = false;
        ChooseDirection();
    }

    void FixedUpdate()
    {
        // Keep Y velocity locked to zero
        Vector3 move = new Vector3(direction.x, 0, direction.z) * speed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + move);
    }

    private void OnTriggerEnter(Collider other)
    {
        bool hit = false;

        // Bounce off walls
        if (other.CompareTag("Wall"))
        {
            direction.z = -direction.z;
            PlaySound(wallHitSFX);
            hit = true;
        }

        // Bounce off rackets
        if (other.CompareTag("Racket"))
        {
            Vector3 newDirection = (transform.position - other.transform.position).normalized;

            newDirection.x = Mathf.Sign(newDirection.x) * Mathf.Max(Mathf.Abs(newDirection.x), minDirection);
            newDirection.z = Mathf.Sign(newDirection.z) * Mathf.Max(Mathf.Abs(newDirection.z), minDirection);

            direction = new Vector3(newDirection.x, 0, newDirection.z).normalized;

            PlaySound(racketHitSFX);
            hit = true;
        }

        // Spawn sparks if hit any surface
        if (hit)
        {
            GameObject sparks = Instantiate(this.sparksVFX, transform.position, transform.rotation);
            Destroy(sparks, 4f);
        }

        // Handle goals
        if (other.CompareTag("GoalLeft"))
        {
            GameController.instance.AddScoreRight();
            ResetBall();
        }

        if (other.CompareTag("GoalRight"))
        {
            GameController.instance.AddScoreLeft();
            ResetBall();
        }
    }

    void ChooseDirection()
    {
        float signX = Mathf.Sign(Random.Range(-1f, 1f));
        float signZ = Mathf.Sign(Random.Range(-1f, 1f));

        direction = new Vector3(0.5f * signX, 0, 0.5f * signZ).normalized;
    }

    public void ResetBall()
    {
        transform.position = Vector3.zero;
        ChooseDirection();
    }

    void PlaySound(AudioClip clip)
    {
        if (clip != null && audioSource != null)
        {
            audioSource.pitch = Random.Range(0.9f, 1.1f); // slight variation for realism
            audioSource.PlayOneShot(clip);
        }
    }
}
