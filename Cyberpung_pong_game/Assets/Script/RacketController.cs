using UnityEngine;

public class RacketControl : MonoBehaviour
{
    public float speed = 10f;      // Movement speed
    public KeyCode up;             // Key for moving up
    public KeyCode down;           // Key for moving down
    public bool isPlayer = true;   // True = player-controlled, False = AI
    public float offset = 0.2f;    // AI follow tolerance

    private Rigidbody rb;
    private Transform ball;
    private const float zLimit = 5f; // Fixed limit (hidden from Inspector)

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.isKinematic = true; // manual movement
        ball = GameObject.FindWithTag("Ball").transform;
    }

    void Update()
    {
        if (isPlayer)
            MoveByPlayer();
        else
            MoveByComputer();
    }

    void MoveByPlayer()
    {
        float move = 0f;

        if (Input.GetKey(up))
            move = speed * Time.deltaTime;
        else if (Input.GetKey(down))
            move = -speed * Time.deltaTime;

        Vector3 newPos = transform.position + new Vector3(0, 0, move);
        newPos.z = Mathf.Clamp(newPos.z, -zLimit, zLimit);
        transform.position = newPos;
    }

    void MoveByComputer()
    {
        if (ball == null) return;

        float move = 0f;

        if (ball.position.z > transform.position.z + offset)
            move = speed * Time.deltaTime;
        else if (ball.position.z < transform.position.z - offset)
            move = -speed * Time.deltaTime;

        Vector3 newPos = transform.position + new Vector3(0, 0, move);
        newPos.z = Mathf.Clamp(newPos.z, -zLimit, zLimit);
        transform.position = newPos;
    }
}
